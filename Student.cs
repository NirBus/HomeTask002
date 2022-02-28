using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTask002
{
    partial class Student
    {
        //Fields
        public string Name;
        public string Surname;
        public string GroupNo;
        public int Age;


    }

    partial class Student
    {
        public Student(string name, string surname, string groupno, int age)
        {
            //Constructor
            Name = name;
            Surname = surname;
            GroupNo = groupno;
            Age = age;
        }
    }
    partial class Student
    {
        //Methods
        public string Getinfo()
        {
            return $"\nName: {Name} \nSurname: {Surname} \nGroupNo: {GroupNo} \nAge: {Age}";

        }
        public static bool CheckName(string name)
        {
            if (name.Length >= 3)
            {
                bool IsUpper = false;


                if (char.IsUpper(name[0]))
                {
                    IsUpper = true;

                }

                bool result = IsUpper;
                return result;
            }
            return false;
        }
        public static bool CheckSurname(string surname)
        {
            if (surname.Length >= 3)
            {
                bool IsUpper = false;


                if (char.IsUpper(surname[0]))
                {
                    IsUpper = true;

                }

                bool result = IsUpper;
                return result;
            }
            return false;
        }
        public static bool CheckGroupno(string groupno)
        {
            if (groupno.Length == 4)
            {
                bool IsUpper = false;


                if (char.IsUpper(groupno[0]))
                {
                    IsUpper = true;

                }

                bool result = IsUpper;
                return result;
            }
            return false;
        }
    }
}

