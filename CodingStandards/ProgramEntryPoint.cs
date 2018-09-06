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
        return writeMessage(dtNow, Console.Out);
    }

    static DateTime dtNow = DateTime.Now;

    public static int writeMessage(DateTime currentDate, TextWriter writer)
    
    {
        int intReturnValue = 0;
        const int messageCount = 5;

        for (int myIndex = 0; myIndex < messageCount; myIndex++)
        {
            /*********************/
            /* greater than 2017 */
            /*********************/

            if (currentDate.Year > 2017)
            {
                writer.WriteLine("Happy New Year!");
            }

            else
            {
                writer.WriteLine("Hello From " + currentDate.Year);
            }
        }
        //--------------------return the result value----------------------------

        return intReturnValue;
    }
}

