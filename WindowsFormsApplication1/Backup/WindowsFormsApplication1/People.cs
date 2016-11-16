using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class student
    {
        public string firstName,
                        lastName;
        public int age;

        public student(string _firstName, string _lastName, int _year)
        {
          
            firstName = _firstName;
            lastName = _lastName;
            age = _year;
        }
    }

    class teacher { 
     public string firstName,
                        lastName;
        public int age;

        private static int idTeacher = 0;

        public int id = 0;



        public string fullName { get {return idTeacher + ". " + firstName + " " + lastName; 
            } 
         }

        public teacher(string _firstName, string _lastName, int _year)
        {
          
            firstName = _firstName;
            lastName = _lastName;
            age = _year;

            teachersList.Add(this);
            idTeacher++;
            id = idTeacher;
            
        }

        private List<student> studentList = new List<student>();

        public void addStudent(student st) {

            studentList.Add(st);
        
        }
        public static teacher findTeacherByIndex(int index){
            foreach (teacher tch in teachersList) {
                if (tch.id == index) return tch;
            }
        }

        public static List<teacher> teachersList = new List<teacher>();
    
    }
}