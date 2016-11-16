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
        public int age,
                    teacherId;


        public student(string _firstName, string _lastName, int _year, int _teacherId)
        {
          
            firstName = _firstName;
            lastName = _lastName;
            age = _year;
            teacherId = _teacherId;

        }
    }

    class teacher { 
     public string firstName,
                        lastName;
        public int age;

        public int idTeacher = 0;

        public teacher(string _firstName, string _lastName, int _year,int _teacherId)
        {
          
            firstName = _firstName;
            lastName = _lastName;
            age = _year;
            idTeacher = _teacherId;
            
        }
    
    }
}