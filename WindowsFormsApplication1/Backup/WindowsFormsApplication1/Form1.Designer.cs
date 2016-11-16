namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.textFirst = new System.Windows.Forms.TextBox();
            this.textLast = new System.Windows.Forms.TextBox();
            this.textYear = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.remove = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonAddStud = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textFirst
            // 
            this.textFirst.Location = new System.Drawing.Point(83, 44);
            this.textFirst.Name = "textFirst";
            this.textFirst.Size = new System.Drawing.Size(100, 20);
            this.textFirst.TabIndex = 0;
            // 
            // textLast
            // 
            this.textLast.Location = new System.Drawing.Point(83, 70);
            this.textLast.Name = "textLast";
            this.textLast.Size = new System.Drawing.Size(100, 20);
            this.textLast.TabIndex = 1;
            // 
            // textYear
            // 
            this.textYear.Location = new System.Drawing.Point(83, 96);
            this.textYear.Name = "textYear";
            this.textYear.Size = new System.Drawing.Size(100, 20);
            this.textYear.TabIndex = 2;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(197, 44);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 3;
            this.Add.Text = "button1";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // remove
            // 
            this.remove.Location = new System.Drawing.Point(197, 73);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(75, 23);
            this.remove.TabIndex = 4;
            this.remove.Text = "button1";
            this.remove.UseVisualStyleBackColor = true;
            this.remove.Click += new System.EventHandler(this.remove_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(125, 192);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // buttonAddStud
            // 
            this.buttonAddStud.Location = new System.Drawing.Point(31, 190);
            this.buttonAddStud.Name = "buttonAddStud";
            this.buttonAddStud.Size = new System.Drawing.Size(75, 23);
            this.buttonAddStud.TabIndex = 6;
            this.buttonAddStud.Text = "AddStudToTeacher";
            this.buttonAddStud.UseVisualStyleBackColor = true;
            this.buttonAddStud.Click += new System.EventHandler(this.buttonAddStud_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.buttonAddStud);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.remove);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.textYear);
            this.Controls.Add(this.textLast);
            this.Controls.Add(this.textFirst);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textFirst;
        private System.Windows.Forms.TextBox textLast;
        private System.Windows.Forms.TextBox textYear;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button remove;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonAddStud;
    }
}

