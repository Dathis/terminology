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
            labelTermName.Text = currentTerm.Name;
            textBoxTermDefinition.Text = currentTerm.Definition;
            listBoxRelatedTerms.Items.Clear();
            foreach (var relatedTerm in currentTerm.RelatedTerms)
            {
                listBoxRelatedTerms.Items.Add(relatedTerm);
            }

        }

        

        private void back_Click(object sender, EventArgs e)
        {

            MainForm form1 = new MainForm();


            this.Hide();

     
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
            if (string.IsNullOrWhiteSpace(textBoxTermDefinition.Text))
            {
                MessageBox.Show("Будь ласка, введіть назву та визначення терміну", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string name = labelTermName.Text;
            string definition = textBoxTermDefinition.Text;


            Term termToEdit = terms.Find(t => t.Name == name);
            if (termToEdit != null)
            {
             
                termToEdit.Definition = definition;
                saveTermin.Visible = false;
                Edit.Visible = true;
                textBoxTermDefinition.Enabled = false;
            }
            else
            {
                
                Term newTerm = new Term { Name = name, Definition = definition, RelatedTerms = new List<string>() };
                if (terms == null)
                {
                    terms = new List<Term>();
                }
               
                terms.Add(newTerm);
            }

        
            SaveData();
        }

        private void deleteTerm_Click(object sender, EventArgs e)
        {
            // Удаляем термин из всех связанных терминов
            foreach (var relatedTermName in currentTerm.RelatedTerms)
            {
                var relatedTerm = terms.Find(t => t.Name == relatedTermName);
                if (relatedTerm != null)
                {
                    relatedTerm.RelatedTerms.Remove(currentTerm.Name);
                }
            }
            terms.Remove(currentTerm);

           
            SaveData();

           
            MainForm form1 = new MainForm();
            this.Hide();
            form1.Show();
        }

        private void listBoxRelatedTerms_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedTermName = listBoxRelatedTerms.SelectedItem.ToString();

            Term selectedTerm = terms.Find(t => t.Name == selectedTermName);
            if (selectedTerm != null)
            {
                FormEditTerm formEditTerm = new FormEditTerm(selectedTerm, terms);
                this.Hide();
                formEditTerm.Show();
            }
        }
    }
    
}
