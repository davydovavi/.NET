using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace exercise1
{
    public class FileStreamer
    {
        static Round round = null;
        public static Round RoundReading(string filename)
        {
            char[] charSeparators = new char[] { ',', ' ', '\n' };
            using (StreamReader fileIn = new StreamReader(filename))
            {
                string[] values = fileIn.ReadToEnd().Split(charSeparators, StringSplitOptions.RemoveEmptyEntries);
                if (double.TryParse(values[0], out double x))
                {
                    if (double.TryParse(values[1], out double y))
                    {
                        if (double.TryParse(values[2], out double radius) && (radius > 0))
                        {
                            round = new Round(x, y, radius);
                        }
                        else
                        {
                            throw new FormatException("Wrong value. Radius must be more than 0");
                        }
                    }
                }
            }
           return round;
        }

        public static void RoundWriting(string filename)
        {
            using (StreamWriter fileOut = new StreamWriter(filename))
            {
                fileOut.WriteLine(round.ToString());
            }
        }
    }
}
