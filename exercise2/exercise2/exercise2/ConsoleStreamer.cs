using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise2
{
    public class ConsoleStreamer
    {
        static User user = null;
        static Employee employee = null;

        public static User UserReading()
        {
            Console.WriteLine("Enter firstname");
            string firstName = Console.ReadLine();
            if (firstName.Length > 0)
            {
                Console.WriteLine("Enter secondname");
                string secondName = Console.ReadLine();
                if (secondName.Length > 0)
                {
                    Console.WriteLine("Enter patronymic");
                    string patronymic = Console.ReadLine();
                    if (patronymic.Length > 0)
                    {
                        Console.WriteLine("Enter date of birth in standard format e.g. dd mm yyyy");
                        if (DateTime.TryParse(Console.ReadLine(), out DateTime birthDate))
                        {
                            user = new User(firstName, secondName, patronymic, birthDate);
                           
                        }
                        else
                        {
                            user = new User(firstName, secondName, patronymic);
                           
                        }
                    }
                }
            }

            return user;
        }

        public static Employee EmployeeReading()
        {
            Console.WriteLine("Enter firstname");
            string firstName = Console.ReadLine();
            if (firstName.Length > 0)
            {
                Console.WriteLine("Enter secondname");
                string secondName = Console.ReadLine();
                if (secondName.Length > 0)
                {
                    Console.WriteLine("Enter patronymic");
                    string patronymic = Console.ReadLine();
                    if (patronymic.Length > 0)
                    {
                        Console.WriteLine("Enter date of birth in standard format e.g. dd mm yyyy");
                        if (DateTime.TryParse(Console.ReadLine(), out DateTime birthDate))
                        {
                            Console.WriteLine("Enter date work experience");
                            if (int.TryParse(Console.ReadLine(), out int workexperience))
                            {
                                Console.WriteLine("Enter position");
                                string position = Console.ReadLine();
                                employee = new Employee(firstName, secondName, patronymic, birthDate, workexperience, position);
                            }
                                

                        }
                        else
                        {
                            Console.WriteLine("Enter date work experience");
                            if (int.TryParse(Console.ReadLine(), out int workexperience))
                            {
                                Console.WriteLine("Enter position");
                                string position = Console.ReadLine();
                                employee = new Employee(firstName, secondName, patronymic, workexperience, position);
                            }
                                

                        }
                    }
                }
            }

            return employee;
        }

        public static void UserWriting()
        {
            Console.WriteLine(user.ToString());
        }

        public static void EmployeeWriting()
        {
            Console.WriteLine(employee.ToString());
        }
    }
}
