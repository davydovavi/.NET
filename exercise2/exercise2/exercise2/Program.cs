using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = null;
            
            Console.WriteLine("User initialization");
            try
            {
                user = ConsoleStreamer.UserReading();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            ConsoleStreamer.UserWriting();

            Employee employee = null;
            Console.WriteLine("Employee initialization");
            try
            {
                employee = new ConsoleStreamer.EmployeeReading();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            ConsoleStreamer.EmployeeWriting();
        }
    }
}
