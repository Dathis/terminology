
namespace Kursovaya
{
    using System;
    using System.Windows.Forms;
    using System.IO;
    using Newtonsoft.Json;
    using System.Collections.Generic;
    public partial class Form1 : Form
    {
        List<Term> terms;
        public Form1()
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = textBox1.Text;
            if (terms == null)
            {
                MessageBox.Show("Нажаль вашого терміну не знайдено :(");
                return;
            }
            List<Term> results = terms.FindAll(t => t.Name.Contains(query) || t.Definition.Contains(query));

            listBox1.Items.Clear();
            foreach (Term term in results)
            {
                listBox1.Items.Add(term);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Получаем выбранный термин
            Term selectedTerm = (Term)listBox1.SelectedItem;

            // Создаем экземпляр новой формы и передаем выбранный термин
            FormEditTerm formEditTerm = new FormEditTerm(selectedTerm, terms);

            // Закрываем текущую форму
            this.Hide();

            // Открываем новую форму
            formEditTerm.Show();
        }
        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            
        }
        private void button2_Click(object sender, EventArgs e)
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
            // Очищаем список терминов
            terms.Clear();

            // Зберігаємо зміни в файл
            SaveData();

            // Обновляемо список терминов на форме
            listBox1.Items.Clear();
        }
        private void SaveData()
        {
            string json = JsonConvert.SerializeObject(terms, Formatting.Indented);
            File.WriteAllText("terms.json", json);
        }
    }
}