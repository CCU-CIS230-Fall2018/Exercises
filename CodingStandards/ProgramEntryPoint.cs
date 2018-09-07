using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    // This is the entry point for the program.
    static int Main(string[] args)
    {
        return WriteMessage(dateNow, Console.Out);
    }

    static DateTime dateNow = DateTime.Now;

    public static int WriteMessage(DateTime CurrentDate, TextWriter writer)
    {
        var returnValue = 0;
        const int messageCount = 5;
        for (int myIndex = 0; myIndex < messageCount; myIndex++)
        {
            // Condition for when the year is greater than 2017.

            if (CurrentDate.Year > 2017)
            {
                writer.WriteLine("Happy New Year!");
            }
            else
            {
                writer.WriteLine("Hello From " + CurrentDate.Year);
            }
        }

        // This statement returns the return value.
        return returnValue;
    }
}

