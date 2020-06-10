using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Round round = null;
            Console.WriteLine("Please, enter the components of round in this order: x, y, radius. If a component is missing, skip it.");
            Console.WriteLine("Enter file name for reading");
            string infilename = Console.ReadLine();
            Console.WriteLine("Enter file name for writing");
            string outfilename = Console.ReadLine();
            try
            {
                round = FileStreamer.RoundReading(infilename);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            if (round!=null)
            {
                try
                {
                    round.Radius *= 2;
                    FileStreamer.RoundWriting(outfilename);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                
            }            
            Console.ReadKey();
        }
    }
}
