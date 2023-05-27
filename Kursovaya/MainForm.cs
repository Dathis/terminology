
namespace Kursovaya
{
    using System;
    using System.Windows.Forms;
    using System.IO;
    using Newtonsoft.Json;
    using System.Collections.Generic;
    public partial class MainForm : Form
    {
        List<Term> terms;
        public MainForm()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            string json = File.ReadAllText("terms.json");
            terms = JsonConvert.DeserializeObject<List<Term>>(json);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string query = textBox1.Text;
            if (string.IsNullOrWhiteSpace(query))
            {
                MessageBox.Show("Будь ласка, введіть назву терміну", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var foundTerms = terms.Where(t => t.Name.ToLowerInvariant().Contains(query.ToLowerInvariant())).ToList();

            if (foundTerms.Count == 0)
            {
                MessageBox.Show("Термін не знайдено.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            termsListBox.Items.Clear();
            foreach (Term term in foundTerms)
            {
                termsListBox.Items.Add(term);
            }
        }

        private void termsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            Term selectedTerm = (Term)termsListBox.SelectedItem;

          
            FormEditTerm formEditTerm = new FormEditTerm(selectedTerm, terms);

          
            this.Hide();

         
            formEditTerm.Show();
        }
        
        private void buttonAddTerm_Click(object sender, EventArgs e)
        {
            // Створюємо екземпляр нової форми
            FormAddTerm formAddTerm = new FormAddTerm();

            // Закриваємо поточну форму
            this.Hide();

            // Показуємо нову форму
            formAddTerm.Show();
        }

        private void DeleteAll_Click(object sender, EventArgs e)
        {
            
            DialogResult dialogResult = MessageBox.Show("Ви впевнені що хочете видалити всі терміни?", "Підтвердження видалення", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {

                terms.Clear();
                SaveData();
                termsListBox.Items.Clear();
            }
        }
        private void SaveData()
        {
            string json = JsonConvert.SerializeObject(terms, Formatting.Indented);
            File.WriteAllText("terms.json", json);
        }
    }
}