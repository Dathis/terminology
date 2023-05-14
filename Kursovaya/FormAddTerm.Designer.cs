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
            this.SuspendLayout();
            // 
            // textBoxTermName
            // 
            this.textBoxTermName.Location = new System.Drawing.Point(13, 44);
            this.textBoxTermName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxTermName.Name = "textBoxTermName";
            this.textBoxTermName.Size = new System.Drawing.Size(756, 24);
            this.textBoxTermName.TabIndex = 0;
            this.textBoxTermName.TextChanged += new System.EventHandler(this.textBoxTermName_TextChanged);
            // 
            // textBoxTermDefinition
            // 
            this.textBoxTermDefinition.Location = new System.Drawing.Point(13, 89);
            this.textBoxTermDefinition.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxTermDefinition.Multiline = true;
            this.textBoxTermDefinition.Name = "textBoxTermDefinition";
            this.textBoxTermDefinition.Size = new System.Drawing.Size(756, 219);
            this.textBoxTermDefinition.TabIndex = 1;
            this.textBoxTermDefinition.TextChanged += new System.EventHandler(this.textBoxTermDefinition_TextChanged);
            // 
            // buttonAddTerm
            // 
            this.buttonAddTerm.Location = new System.Drawing.Point(229, 314);
            this.buttonAddTerm.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonAddTerm.Name = "buttonAddTerm";
            this.buttonAddTerm.Size = new System.Drawing.Size(324, 43);
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
            // FormAddTerm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
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
    }
}