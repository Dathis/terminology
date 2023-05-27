namespace Kursovaya
{
    partial class FormEditTerm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.labelTermName = new System.Windows.Forms.Label();
            this.textBoxTermDefinition = new System.Windows.Forms.TextBox();
            this.Edit = new System.Windows.Forms.Button();
            this.deleteTerm = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.saveTermin = new System.Windows.Forms.Button();
            this.listBoxRelatedTerms = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = " ";
            // 
            // labelTermName
            // 
            this.labelTermName.AutoSize = true;
            this.labelTermName.Font = new System.Drawing.Font("Gotham Pro Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTermName.Location = new System.Drawing.Point(12, 40);
            this.labelTermName.Name = "labelTermName";
            this.labelTermName.Size = new System.Drawing.Size(72, 23);
            this.labelTermName.TabIndex = 1;
            this.labelTermName.Text = "label2";
            // 
            // textBoxTermDefinition
            // 
            this.textBoxTermDefinition.Enabled = false;
            this.textBoxTermDefinition.Location = new System.Drawing.Point(12, 76);
            this.textBoxTermDefinition.Multiline = true;
            this.textBoxTermDefinition.Name = "textBoxTermDefinition";
            this.textBoxTermDefinition.Size = new System.Drawing.Size(776, 218);
            this.textBoxTermDefinition.TabIndex = 2;
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(486, 334);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(148, 29);
            this.Edit.TabIndex = 3;
            this.Edit.Text = "Редагувати";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // deleteTerm
            // 
            this.deleteTerm.BackColor = System.Drawing.Color.Brown;
            this.deleteTerm.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deleteTerm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.deleteTerm.Location = new System.Drawing.Point(640, 334);
            this.deleteTerm.Name = "deleteTerm";
            this.deleteTerm.Size = new System.Drawing.Size(148, 29);
            this.deleteTerm.TabIndex = 4;
            this.deleteTerm.Text = "Видалити";
            this.deleteTerm.UseVisualStyleBackColor = false;
            this.deleteTerm.Click += new System.EventHandler(this.deleteTerm_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(12, 409);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(94, 29);
            this.back.TabIndex = 5;
            this.back.Text = "назад";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // saveTermin
            // 
            this.saveTermin.Location = new System.Drawing.Point(486, 334);
            this.saveTermin.Name = "saveTermin";
            this.saveTermin.Size = new System.Drawing.Size(148, 29);
            this.saveTermin.TabIndex = 6;
            this.saveTermin.Text = "Зберегти";
            this.saveTermin.UseVisualStyleBackColor = true;
            this.saveTermin.Visible = false;
            this.saveTermin.Click += new System.EventHandler(this.saveTermin_Click_1);
            // 
            // listBoxRelatedTerms
            // 
            this.listBoxRelatedTerms.FormattingEnabled = true;
            this.listBoxRelatedTerms.ItemHeight = 20;
            this.listBoxRelatedTerms.Location = new System.Drawing.Point(12, 334);
            this.listBoxRelatedTerms.Name = "listBoxRelatedTerms";
            this.listBoxRelatedTerms.Size = new System.Drawing.Size(234, 44);
            this.listBoxRelatedTerms.TabIndex = 7;
            this.listBoxRelatedTerms.SelectedIndexChanged += new System.EventHandler(this.listBoxRelatedTerms_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gotham Pro", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Зв\'язані терміни";
            // 
            // FormEditTerm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxRelatedTerms);
            this.Controls.Add(this.saveTermin);
            this.Controls.Add(this.back);
            this.Controls.Add(this.deleteTerm);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.textBoxTermDefinition);
            this.Controls.Add(this.labelTermName);
            this.Controls.Add(this.label1);
            this.Name = "FormEditTerm";
            this.Text = "FormEditTerm";
            this.Load += new System.EventHandler(this.FormEditTerm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label labelTermName;
        private TextBox textBoxTermDefinition;
        private Button Edit;
        private Button deleteTerm;
        private Button back;
        private Button saveTermin;
        private ListBox listBoxRelatedTerms;
        private Label label2;
    }
}