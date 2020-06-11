using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise2
{
    public class Employee: User
    {
        private int _workExperience;

        public string Position { get; set; }

        public Employee(string firstName, string secondName, string patronymic, DateTime birthDate, int workExperience, string position)
            :base(firstName,  secondName,  patronymic,  birthDate)
        {
            WorkExperience = workExperience;
            Position = position;
        }

        public Employee(string firstName, string secondName, string patronymic, int workExperience, string position)
            : base(firstName, secondName, patronymic)
        {
            WorkExperience = workExperience;
            Position = position;
        }

        public int WorkExperience
        {
            set
            {
                if (value >= 0)
                {
                    _workExperience = value;
                }
                else
                {
                    throw new Exception("Work experience must be greater than 0");
                }
            }
            get
            {
                return _workExperience;
            }
        }

        public override string ToString()
        {
            return $"Work experience = {WorkExperience}, position = {Position}";
        }
    }
}
