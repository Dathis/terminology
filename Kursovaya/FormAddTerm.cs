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

        }

        private void textBoxTermName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxTermDefinition_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAddTerm_Click(object sender, EventArgs e)
        {
            // Отримуємо введені дані
            string name = textBoxTermName.Text;
            string definition = textBoxTermDefinition.Text;

            // Створюємо новий термін
            Term newTerm = new Term { Name = name, Definition = definition, RelatedTerms = new List<string>() };
            if (terms == null)
            {
                terms = new List<Term>();
            }
            // Додаємо новий термін до списку
            terms.Add(newTerm);

            // Очищуємо текстові поля
            textBoxTermName.Clear();
            textBoxTermDefinition.Clear();

            // Зберігаємо зміни в файл
            SaveData();
        }
        private void SaveData()
        {
            string json = JsonConvert.SerializeObject(terms, Formatting.Indented);
            File.WriteAllText("terms.json", json);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Створюємо екземпляр нової форми
            Form1 form1 = new Form1();

            // Закриваємо поточну форму
            this.Hide();

            // Показуємо нову форму
            form1.Show();
        }
    }
}
