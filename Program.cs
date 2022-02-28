using System;

namespace HomeTask002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student ven = new Student("Alik", "Gafarov", "P127", 20);
            string nam;
            string sur;
            string grp;
            do
            {

                Console.WriteLine("Name Daxil edin:");
                nam = Console.ReadLine();

            } while (!Student.CheckName(nam));
            do
            {

                Console.WriteLine("Surname Daxil edin:");
                sur = Console.ReadLine();

            } while (!Student.CheckSurname(sur));
            do
            {

                Console.WriteLine("GroupNo Daxil edin:");
                grp = Console.ReadLine();

            } while (!Student.CheckGroupno(grp));

            if (!Student.CheckName(nam) == false && !Student.CheckSurname(sur) == false && !Student.CheckGroupno(grp) == false)
            {

                Console.WriteLine(ven.Getinfo());
            }








        }
    }
}
 
