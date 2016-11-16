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
            this.textFirstTeacher = new System.Windows.Forms.TextBox();
            this.textLastTeacher = new System.Windows.Forms.TextBox();
            this.textYearTeacher = new System.Windows.Forms.TextBox();
            this.buttonAddStudent = new System.Windows.Forms.Button();
            this.buttonAddTeacher = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listStud = new System.Windows.Forms.ListBox();
            this.textYearStudent = new System.Windows.Forms.TextBox();
            this.textLastStudent = new System.Windows.Forms.TextBox();
            this.textFirstStudent = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.listStudent = new System.Windows.Forms.ListBox();
            this.removeStudent = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonSort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textFirstTeacher
            // 
            this.textFirstTeacher.Location = new System.Drawing.Point(31, 47);
            this.textFirstTeacher.Name = "textFirstTeacher";
            this.textFirstTeacher.Size = new System.Drawing.Size(100, 20);
            this.textFirstTeacher.TabIndex = 0;
            // 
            // textLastTeacher
            // 
            this.textLastTeacher.Location = new System.Drawing.Point(31, 73);
            this.textLastTeacher.Name = "textLastTeacher";
            this.textLastTeacher.Size = new System.Drawing.Size(100, 20);
            this.textLastTeacher.TabIndex = 1;
            // 
            // textYearTeacher
            // 
            this.textYearTeacher.Location = new System.Drawing.Point(31, 99);
            this.textYearTeacher.Name = "textYearTeacher";
            this.textYearTeacher.Size = new System.Drawing.Size(100, 20);
            this.textYearTeacher.TabIndex = 2;
            // 
            // buttonAddStudent
            // 
            this.buttonAddStudent.Location = new System.Drawing.Point(331, 12);
            this.buttonAddStudent.Name = "buttonAddStudent";
            this.buttonAddStudent.Size = new System.Drawing.Size(75, 23);
            this.buttonAddStudent.TabIndex = 3;
            this.buttonAddStudent.Text = "AddStudent";
            this.buttonAddStudent.UseVisualStyleBackColor = true;
            this.buttonAddStudent.Click += new System.EventHandler(this.AddStudent_Click);
            // 
            // buttonAddTeacher
            // 
            this.buttonAddTeacher.Location = new System.Drawing.Point(56, 12);
            this.buttonAddTeacher.Name = "buttonAddTeacher";
            this.buttonAddTeacher.Size = new System.Drawing.Size(75, 23);
            this.buttonAddTeacher.TabIndex = 4;
            this.buttonAddTeacher.Text = "AddTeacher";
            this.buttonAddTeacher.UseVisualStyleBackColor = true;
            this.buttonAddTeacher.Click += new System.EventHandler(this.AddTeacher_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(40, 199);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // listStud
            // 
            this.listStud.FormattingEnabled = true;
            this.listStud.Location = new System.Drawing.Point(31, 257);
            this.listStud.Name = "listStud";
            this.listStud.Size = new System.Drawing.Size(371, 173);
            this.listStud.TabIndex = 7;
            // 
            // textYearStudent
            // 
            this.textYearStudent.Location = new System.Drawing.Point(331, 99);
            this.textYearStudent.Name = "textYearStudent";
            this.textYearStudent.Size = new System.Drawing.Size(100, 20);
            this.textYearStudent.TabIndex = 11;
            // 
            // textLastStudent
            // 
            this.textLastStudent.Location = new System.Drawing.Point(331, 73);
            this.textLastStudent.Name = "textLastStudent";
            this.textLastStudent.Size = new System.Drawing.Size(100, 20);
            this.textLastStudent.TabIndex = 10;
            // 
            // textFirstStudent
            // 
            this.textFirstStudent.Location = new System.Drawing.Point(331, 47);
            this.textFirstStudent.Name = "textFirstStudent";
            this.textFirstStudent.Size = new System.Drawing.Size(100, 20);
            this.textFirstStudent.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "FirstName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "LastName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(137, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Year";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(271, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "FirstName";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(270, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "LastName";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(296, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Year";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(331, 125);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 19;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(248, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "ProvideTeacher";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(167, 207);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "SelectTeacher";
            // 
            // listStudent
            // 
            this.listStudent.FormattingEnabled = true;
            this.listStudent.Location = new System.Drawing.Point(458, 73);
            this.listStudent.Name = "listStudent";
            this.listStudent.Size = new System.Drawing.Size(241, 355);
            this.listStudent.TabIndex = 22;
            // 
            // removeStudent
            // 
            this.removeStudent.Location = new System.Drawing.Point(624, 37);
            this.removeStudent.Name = "removeStudent";
            this.removeStudent.Size = new System.Drawing.Size(75, 23);
            this.removeStudent.TabIndex = 23;
            this.removeStudent.Text = "Remove";
            this.removeStudent.UseVisualStyleBackColor = true;
            this.removeStudent.Click += new System.EventHandler(this.removeStudent_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(550, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "AllStudent";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(261, 231);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "AllStudentTeacher";
            // 
            // buttonSort
            // 
            this.buttonSort.Location = new System.Drawing.Point(458, 37);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(75, 23);
            this.buttonSort.TabIndex = 26;
            this.buttonSort.Text = "Sort";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 443);
            this.Controls.Add(this.buttonSort);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.removeStudent);
            this.Controls.Add(this.listStudent);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textYearStudent);
            this.Controls.Add(this.textLastStudent);
            this.Controls.Add(this.textFirstStudent);
            this.Controls.Add(this.listStud);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonAddTeacher);
            this.Controls.Add(this.buttonAddStudent);
            this.Controls.Add(this.textYearTeacher);
            this.Controls.Add(this.textLastTeacher);
            this.Controls.Add(this.textFirstTeacher);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textFirstTeacher;
        private System.Windows.Forms.TextBox textLastTeacher;
        private System.Windows.Forms.TextBox textYearTeacher;
        private System.Windows.Forms.Button buttonAddStudent;
        private System.Windows.Forms.Button buttonAddTeacher;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListBox listStud;
        private System.Windows.Forms.TextBox textYearStudent;
        private System.Windows.Forms.TextBox textLastStudent;
        private System.Windows.Forms.TextBox textFirstStudent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox listStudent;
        private System.Windows.Forms.Button removeStudent;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonSort;
    }
}

