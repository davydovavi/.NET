using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise2
{
    public class User
    {
        public string FirstName { get; set; }

        public string SecondName { get; set; }

        public string Patronymic { get; set; }

        public DateTime BirthDate { get; set; } = DateTime.Parse("01 01 2000");

        private readonly int _age;

        public User(string firstName, string secondName, string patronymic, DateTime birthDate)
        {
            FirstName = firstName;
            SecondName = secondName;
            Patronymic = patronymic;
            BirthDate = birthDate;
        }

        public User(string firstName, string secondName, string patronymic)
        {
            FirstName = firstName;
            SecondName = secondName;
            Patronymic = patronymic;
        }

        public int Age
        {
            get
            {
                DateTime now = DateTime.Today;
                int age = now.Year - BirthDate.Year;
                if (BirthDate > now.AddYears(-age)) age--;
                return age;
            }
        }

        public override string ToString()
        {
            return $"Firstname = {FirstName},\n Secondname = {SecondName}, \n Patronymic = {Patronymic}, \n Birthdate = {BirthDate}, \n Age = {Age}";
        }

    }
}
