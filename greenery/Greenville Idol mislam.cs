using System;
using static System.Console;
using System.Linq;
using System.Text.RegularExpressions;


namespace greenery
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

            var inp = ReadLine();
            if (inp == "1")
            {
                Write("The number of contestants in the previous year: ");
                int prevy = int.Parse(ReadLine());

                Write("The number of contestants in the current year: ");
                int currentyearsports = int.Parse(ReadLine());
                WriteLine();

                WriteLine($"Last year's competition had {prevy} contestants, and this year's has {currentyearsports} contestants");

                int expectedcash = currentyearsports * 25;
                string v = expectedcash.ToString("n0");
                WriteLine($"Revenue expected this year is {v}$");

                bool larger = currentyearsports > (2 * prevy);
                bool compare = currentyearsports > prevy;

                if (!larger)
                {
                    if (compare)
                    {
                        WriteLine("The competition is bigger than ever!");
                    }
                    else
                    {
                        WriteLine("A tighter race this year! Come out and cast your vote!");
                    }
                }
                else
                {
                    WriteLine("The competition is more than twice as big this year!");
                }
            }
            else if (inp == "2")
            {
                WriteLine("Thank you for using the Greenville Revenue App, good-bye!");
            }

            ReadKey();
        }
    }
}
