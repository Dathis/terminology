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
    public partial class FormEditTerm : Form
    {
        public Term currentTerm;
        private List<Term> terms;
        public FormEditTerm(Term selectedTerm, List<Term> termsList)
        {
            InitializeComponent();
            this.currentTerm = selectedTerm;
            this.terms = termsList;
            labelTermName.Text = currentTerm.Name;
            textBoxTermDefinition.Text = currentTerm.Definition;

        }

        private void FormEditTerm_Load(object sender, EventArgs e)
        {

        }

        private void labelTermName_Click(object sender, EventArgs e)
        {

        }

        private void textBoxTermDefinition_TextChanged(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            // Створюємо екземпляр нової форми
            Form1 form1 = new Form1();

            // Закриваємо поточну форму
            this.Hide();

            // Показуємо нову форму
            form1.Show();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            textBoxTermDefinition.Enabled = true;
            textBoxTermDefinition.Focus();
            Edit.Visible = false;
            saveTermin.Visible = true;
        }
       
        private void SaveData()
        {
            string json = JsonConvert.SerializeObject(terms, Formatting.Indented);
            File.WriteAllText("terms.json", json);
        }

        private void saveTermin_Click_1(object sender, EventArgs e)
        {
            string name = labelTermName.Text;
            string definition = textBoxTermDefinition.Text;

            // Знаходимо в списку вибраний термін
            Term termToEdit = terms.Find(t => t.Name == name);
            if (termToEdit != null)
            {
                // Обновляемо визначення терміна
                termToEdit.Definition = definition;
                saveTermin.Visible = false;
                Edit.Visible = true;
                textBoxTermDefinition.Enabled = false;
            }
            else
            {
                // Якщо терміна немає в списку, створюємо новий
                Term newTerm = new Term { Name = name, Definition = definition, RelatedTerms = new List<string>() };
                if (terms == null)
                {
                    terms = new List<Term>();
                }
                // Додаємо новий термін до списку
                terms.Add(newTerm);
            }

            // Зберігаємо зміни в файл
            SaveData();
        }

        private void deleteTerm_Click(object sender, EventArgs e)
        {
            // Удаляем выбранный термин из списка
            terms.Remove(currentTerm);

            // Сохраняем изменения в файле
            SaveData();

            // Возвращаемся на главную форму
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }
    }
    
}
