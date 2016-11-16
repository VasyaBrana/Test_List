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
        int idTeach = 0;
        int currentTeacher2 = 0;
        int currentTeacherId = 0;


        List<student> addStud = new List<student>();
        List<teacher> addTeach = new List<teacher>();

        public Form1()
        {
            InitializeComponent();
            AddPeople();
        }

        private void AddStudent_Click(object sender, EventArgs e)
        {
            int ps;
            bool result = !Int32.TryParse(Convert.ToString(textYearStudent.Text), out ps);

            if (textFirstStudent.Text != "" && textLastStudent.Text != "" && textYearStudent.Text != "" && !result)
            {
                student newStudent = new student(textFirstStudent.Text, textLastStudent.Text, Convert.ToInt32(textYearStudent.Text), currentTeacher2);

                addStud.Add(newStudent);

                showStudent();
                showStudentToTeacher();
            }
            else {
                if(result)
                {
                    MessageBox.Show("Поле 'Year' чисельного типу");

                }else
                    {

                    MessageBox.Show("Заповніть усі поля");
                }
            }
        }

        private void AddTeacher_Click(object sender, EventArgs e)
        {
            int ps;
            bool result = !Int32.TryParse(Convert.ToString(textYearTeacher.Text), out ps);

            if (textFirstTeacher.Text != "" && textLastTeacher.Text != "" && textYearTeacher.Text != "" && !result)
            {

                teacher newTeacher = new teacher(textFirstTeacher.Text, textLastTeacher.Text, Convert.ToInt32(textYearTeacher.Text), idTeach);

                addTeach.Add(newTeacher);
                idTeach++;

                showTeacher();

            }
            else { 


                if (result)
                {
                    MessageBox.Show("Поле 'Year' чисельного типу");
                }
                else {
                    MessageBox.Show("Заповніть усі поля");
                }

            }
        }

        public void showTeacher()
        {
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();

            for (int i = 0; i < addTeach.Count; i++)
            {
                comboBox2.Items.Add(addTeach[i].idTeacher + ". " + addTeach[i].firstName + " " + addTeach[i].lastName);
                comboBox1.Items.Add(addTeach[i].idTeacher + ". " + addTeach[i].firstName + " " + addTeach[i].lastName);
            }
        }

        public void showStudentToTeacher()
        {
            listStud.Items.Clear();

            listStud.Sorted = true;

            for (int i = 0; i < addStud.Count; i++)
            {
                if (addStud[i].teacherId == currentTeacherId)
                {

                    listStud.Items.Add(Convert.ToString(addStud[i].firstName) + " " + Convert.ToString(addStud[i].lastName));
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string currentTeacher = comboBox1.SelectedItem.ToString();

            currentTeacherId = Convert.ToInt32(currentTeacher.Substring(0, currentTeacher.IndexOf(".")));

            showStudentToTeacher();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string currentTeacher = comboBox2.SelectedItem.ToString();

            currentTeacher2 = Convert.ToInt32(currentTeacher.Substring(0, currentTeacher.IndexOf(".")));
        }

        public void showStudent()
        {
            listStudent.Items.Clear();

            for (int i = 0; i < addStud.Count; i++)
            {

                    listStudent.Items.Add(Convert.ToString(addStud[i].firstName) + " " + Convert.ToString(addStud[i].lastName));
            }
        }

        private void removeStudent_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < addStud.Count; i++) {
                if (listStudent.GetSelected(i))    
                {
                    addStud.RemoveAt(i);
                    i = addStud.Count;
                    showStudent();
                    showStudentToTeacher();
                }
            }

        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < addStud.Count - 1; j++) {

                for (int i = 0; i < addStud.Count - 1; i++)
                {

                    if (string.Compare(addStud[i].firstName, addStud[i + 1].firstName) > 0)
                    {

                        student s = addStud[i];
                        addStud[i] = addStud[i + 1];
                        addStud[i + 1] = s;

                    }
                }
                showStudent();
                showStudentToTeacher();

            }
        }

        public void AddPeople()
        {


            addStud.Add(new student("Василь","Брана",19,0));
            addStud.Add(new student("Тетяна", "Богачук", 19, 0));
            addStud.Add(new student("Богдан", "Олійник", 19, 0));
            addStud.Add(new student("Олександер", "Велищук", 19, 0));
            addStud.Add(new student("Андрй", "Ющишин", 19, 0));
            addStud.Add(new student("Андрій", "Яніцький", 19, 0));
            addStud.Add(new student("Анастасія", "Бабій", 19, 0));
            addStud.Add(new student("Назар", "Янишин", 19, 0));
            addStud.Add(new student("Сергій", "Дідик", 19, 0));
            addStud.Add(new student("Михайло", "Мартинюк", 19, 0));
            addStud.Add(new student("Наталя", "Кавка", 19, 0));
            addStud.Add(new student("Валентин", "Когут", 19, 0));
            addStud.Add(new student("Іван", "Салюк", 19, 0));
            addStud.Add(new student("Арсен", "Губай", 19, 0));
            addStud.Add(new student("Анатолій", "Дмитарко", 19, 0));

            addStud.Add(new student("Роман", "Зуляк", 19, 1));
            addStud.Add(new student("Тарас", "Зуляк", 19, 1));
            addStud.Add(new student("Валентин", "Ярема", 19, 1));
            addStud.Add(new student("Володимир", "Фриюк", 19, 1));
            addStud.Add(new student("Андрй", "Фриюк", 19, 1));
            addStud.Add(new student("Володимир", "Чубрій", 19, 1));
            addStud.Add(new student("Роман", "Гирик", 19, 1));
            addStud.Add(new student("Святослав", "Дзюбак", 19, 1));
            addStud.Add(new student("Тетяна", "Бугера", 19, 1));
            addStud.Add(new student("Ірина", "Парняк", 19, 2));
            addStud.Add(new student("Наталя", "Бондар", 19, 2));
            addStud.Add(new student("Микола", "Бргачук", 19, 2));
            addStud.Add(new student("Ігор", "Куліковський", 19, 2));
            addStud.Add(new student("Тетяна", "Климчук", 19, 2));
            addStud.Add(new student("Ольга", "Медвідь", 19, 2));

            addTeach.Add(new teacher("Василь", "Петрович", 45, idTeach));
            idTeach++;
            addTeach.Add(new teacher("Володимир", "Андрійович", 45, idTeach));
            idTeach++;
            addTeach.Add(new teacher("Василь", "Данилович", 45, idTeach));
            idTeach++;

            showStudent();
            showTeacher();
        }


    }
}
