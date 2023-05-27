using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursovaya
{
    
    public partial class FormAddTerm : Form
    {
        private Term newTerm;
        private List<Term> terms;
        public FormAddTerm()
        {
            InitializeComponent();
            this.terms = terms;
            LoadData();
        }
        private void LoadData()
        {
            if (File.Exists("terms.json"))
            {
                string json = File.ReadAllText("terms.json");
                terms = JsonConvert.DeserializeObject<List<Term>>(json);
            }
            else
            {
                terms = new List<Term>();
            }
        }
        
        private void FormAddTerm_Load(object sender, EventArgs e)
        {
            newTerm = new Term { RelatedTerms = new List<string>() };
            foreach (Term term in terms)
            {
                listBoxRelatedTerms.Items.Add(term.Name);
            }

        }

        

        private void buttonAddTerm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxTermName.Text) || string.IsNullOrWhiteSpace(textBoxTermDefinition.Text))
            {
                MessageBox.Show("Будь ласка, введіть назву та визначення терміну", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (terms.Any(t => t.Name == textBoxTermName.Text))
            {
                MessageBox.Show("Такий термін вже існує", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Створюємо новий термін
            newTerm.Name = textBoxTermName.Text;
            newTerm.Definition = textBoxTermDefinition.Text;
            if (terms == null)
            {
                terms = new List<Term>();
            }
            terms.Add(newTerm);
            foreach (var relatedTermName in newTerm.RelatedTerms)
            {
                var relatedTerm = terms.Find(t => t.Name == relatedTermName);
                if (relatedTerm != null && !relatedTerm.RelatedTerms.Contains(newTerm.Name))
                {
                    relatedTerm.RelatedTerms.Add(newTerm.Name);
                }
            }

            textBoxTermName.Clear();
            textBoxTermDefinition.Clear();

            SaveData();
            //ініціалізуємо новий термін 
            newTerm = new Term { RelatedTerms = new List<string>() };

        }
        private void SaveData()
        {
            string json = JsonConvert.SerializeObject(terms, Formatting.Indented);
            File.WriteAllText("terms.json", json);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm form1 = new MainForm();
            this.Hide();
            form1.Show();
        }

       

        private void buttonAddRelation_Click(object sender, EventArgs e)
        {
            
            string selectedTerm = listBoxRelatedTerms.SelectedItem.ToString();

            if (!newTerm.RelatedTerms.Contains(selectedTerm))
            {
                newTerm.RelatedTerms.Add(selectedTerm);
            }
            else
            {
                MessageBox.Show("Термін уже зв'язан.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
