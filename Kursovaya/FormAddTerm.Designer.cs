namespace Kursovaya
{
    partial class FormAddTerm
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
            this.textBoxTermName = new System.Windows.Forms.TextBox();
            this.textBoxTermDefinition = new System.Windows.Forms.TextBox();
            this.buttonAddTerm = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAddRelation = new System.Windows.Forms.Button();
            this.listBoxRelatedTerms = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // textBoxTermName
            // 
            this.textBoxTermName.Location = new System.Drawing.Point(12, 61);
            this.textBoxTermName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxTermName.Name = "textBoxTermName";
            this.textBoxTermName.Size = new System.Drawing.Size(756, 24);
            this.textBoxTermName.TabIndex = 0;
            // 
            // textBoxTermDefinition
            // 
            this.textBoxTermDefinition.Location = new System.Drawing.Point(13, 157);
            this.textBoxTermDefinition.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxTermDefinition.Multiline = true;
            this.textBoxTermDefinition.Name = "textBoxTermDefinition";
            this.textBoxTermDefinition.Size = new System.Drawing.Size(756, 219);
            this.textBoxTermDefinition.TabIndex = 1;
            // 
            // buttonAddTerm
            // 
            this.buttonAddTerm.Location = new System.Drawing.Point(13, 382);
            this.buttonAddTerm.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonAddTerm.Name = "buttonAddTerm";
            this.buttonAddTerm.Size = new System.Drawing.Size(152, 43);
            this.buttonAddTerm.TabIndex = 2;
            this.buttonAddTerm.Text = "Додати термін";
            this.buttonAddTerm.UseVisualStyleBackColor = true;
            this.buttonAddTerm.Click += new System.EventHandler(this.buttonAddTerm_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 512);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 3;
            this.button1.Text = "назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Назва терміну";
            
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Визначення терміну";
       
            // 
            // buttonAddRelation
            // 
            this.buttonAddRelation.Location = new System.Drawing.Point(619, 382);
            this.buttonAddRelation.Name = "buttonAddRelation";
            this.buttonAddRelation.Size = new System.Drawing.Size(149, 43);
            this.buttonAddRelation.TabIndex = 6;
            this.buttonAddRelation.Text = "Зв\'язати термін";
            this.buttonAddRelation.UseVisualStyleBackColor = true;
            this.buttonAddRelation.Click += new System.EventHandler(this.buttonAddRelation_Click);
            // 
            // listBoxRelatedTerms
            // 
            this.listBoxRelatedTerms.FormattingEnabled = true;
            this.listBoxRelatedTerms.ItemHeight = 17;
            this.listBoxRelatedTerms.Location = new System.Drawing.Point(469, 438);
            this.listBoxRelatedTerms.Name = "listBoxRelatedTerms";
            this.listBoxRelatedTerms.Size = new System.Drawing.Size(299, 106);
            this.listBoxRelatedTerms.TabIndex = 7;
            // 
            // FormAddTerm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.listBoxRelatedTerms);
            this.Controls.Add(this.buttonAddRelation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonAddTerm);
            this.Controls.Add(this.textBoxTermDefinition);
            this.Controls.Add(this.textBoxTermName);
            this.Font = new System.Drawing.Font("Gotham Pro Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormAddTerm";
            this.Text = "FormAddTerm";
            this.Load += new System.EventHandler(this.FormAddTerm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxTermName;
        private TextBox textBoxTermDefinition;
        private Button buttonAddTerm;
        private Button button1;
        private Label label1;
        private Label label2;
        private Button buttonAddRelation;
        private ListBox listBoxRelatedTerms;
    }
}