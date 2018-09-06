using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// This is the program that will show us if we are coding correctly.
class Program
{
	// Initializing variables.
	static DateTime now = DateTime.Now;

	// This is the entry point for the program.
	static int Main(string[] args)
    {
        return WriteMessage(now, Console.Out);
    }


	// This method will write the message.
    public static int WriteMessage(DateTime currentDate, TextWriter writer)
    {
        var returnValue = 0;
		const int messageCount = 5;
		for (int myIndex = 0; myIndex < messageCount; myIndex++)
		{
			// If the year is greater than 2017.
			if (currentDate.Year > 2017)
			{
				writer.WriteLine("Happy New Year!");
			}
			else
			{
				writer.WriteLine("Hello From " + currentDate.Year);
			}
		}
        // Return the result value.
		return returnValue;
    }
}

