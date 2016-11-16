using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<student> addStud = new List<student>();

        private void Add_Click(object sender, EventArgs e)
        {
            if (textFirst.Text != "" && textLast.Text != "" && textYear.Text != "")
            {
                addStud.Add(new student(textFirst.Text, textLast.Text, Convert.ToInt32(textYear.Text)));
                textFirst.Text = textLast.Text = textYear.Text = "";
            }
            else {
                MessageBox.Show("Заповніть усі поля");
            }
        }

        private void remove_Click(object sender, EventArgs e)
        {
            teacher teacher1 = new teacher(textFirst.Text, textLast.Text, Convert.ToInt32(textYear.Text));
            comboBox1.Items.Add(teacher1.fullName);
        }

        private void buttonAddStud_Click(object sender, EventArgs e)
        {
            if (textFirst.Text != "" && textLast.Text != "" && textYear.Text != "")
            {
               student st1 = new student(textFirst.Text, textLast.Text, Convert.ToInt32(textYear.Text));

               string str = comboBox1.SelectedItem.ToString();

                int index = Convert.ToInt32(str.Substring(0, str.IndexOf(".")));
              

               

                textFirst.Text = textLast.Text = textYear.Text = "";

            }
            else
            {
                MessageBox.Show("Заповніть усі поля");
            }
        }
    }
}
