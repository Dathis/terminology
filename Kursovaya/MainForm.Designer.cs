namespace Kursovaya
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.termsListBox = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.buttonAddTerm = new System.Windows.Forms.Button();
            this.DeleteAll = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // termsListBox
            // 
            this.termsListBox.FormattingEnabled = true;
            this.termsListBox.ItemHeight = 19;
            this.termsListBox.Location = new System.Drawing.Point(30, 137);
            this.termsListBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.termsListBox.Name = "termsListBox";
            this.termsListBox.Size = new System.Drawing.Size(739, 213);
            this.termsListBox.TabIndex = 0;
            this.termsListBox.SelectedIndexChanged += new System.EventHandler(this.termsListBox_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(30, 78);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(517, 27);
            this.textBox1.TabIndex = 7;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(554, 78);
            this.searchButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(162, 27);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Пошук";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // buttonAddTerm
            // 
            this.buttonAddTerm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddTerm.Location = new System.Drawing.Point(523, 501);
            this.buttonAddTerm.Name = "buttonAddTerm";
            this.buttonAddTerm.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonAddTerm.Size = new System.Drawing.Size(247, 40);
            this.buttonAddTerm.TabIndex = 3;
            this.buttonAddTerm.Text = "Додати новий термін";
            this.buttonAddTerm.UseVisualStyleBackColor = true;
            this.buttonAddTerm.Click += new System.EventHandler(this.buttonAddTerm_Click);
            // 
            // DeleteAll
            // 
            this.DeleteAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DeleteAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DeleteAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DeleteAll.Location = new System.Drawing.Point(30, 356);
            this.DeleteAll.Name = "DeleteAll";
            this.DeleteAll.Size = new System.Drawing.Size(232, 27);
            this.DeleteAll.TabIndex = 4;
            this.DeleteAll.Text = "Видалити всі терміни";
            this.DeleteAll.UseVisualStyleBackColor = false;
            this.DeleteAll.Click += new System.EventHandler(this.DeleteAll_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Назва терміну";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Список знайдених термінів";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DeleteAll);
            this.Controls.Add(this.buttonAddTerm);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.termsListBox);
            this.Font = new System.Drawing.Font("Gotham Pro Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainForm";
            this.Text = "Terms DB";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox termsListBox;
        private TextBox textBox1;
        private Button searchButton;
        private Button buttonAddTerm;
        private Button DeleteAll;
        private Label label1;
        private Label label2;
    }
}