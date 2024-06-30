using System;
using static System.Console;



// purposely does not include error handling if any non imt values are entered

namespace pr213k
{
    public class Program
    {
        static void Main(string[] args)
        {
            Write("************************************\n");
            Write("*  The stars shine in Greenville.  *\n");
            Write("************************************\n");
            WriteLine();
            Write("Please enter the following number below from the following menu:\n");
            WriteLine();
            Write("1. CALCULATE Greenville Revenue Year-Over-Year\n");
            Write("2. Exit\n");

            string inp = ReadLine();

            if (inp == "1")
            {
                Write(" The number of contestants in the previous year: ");
                int prevy = int.Parse(ReadLine());

                Write(" The number of contestants in the current year: ");
                int currentyearsports = int.Parse(ReadLine());

                WriteLine($"Last year's competition had {prevy} contestants, and this year's has {currentyearsports} contestants");

                int expectedcash = currentyearsports * 25;
                string v = expectedcash.ToString(format: "n0");
                WriteLine($"Revenue expected this year is {v}$");

                bool compare = currentyearsports > prevy;
                WriteLine($"It is {(compare ? "true" : "false")} that this year's competition is bigger than last year's.");
            }
            else if (inp == "2")
            {
                WriteLine("Thank you for using the Greenville Revenue App, good-bye!");
            }

            ReadKey();
        }
    }
}
