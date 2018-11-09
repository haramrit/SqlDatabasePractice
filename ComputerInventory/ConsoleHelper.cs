using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerInventory
{
    public class ConsoleHelper
    {
        // Helper Method to write header in the centre of the screen.
        public static void WriteHeader(string headerText)
        {
            Console.WriteLine(string.Format("{0," + ((Console.WindowWidth / 2) +
    headerText.Length / 2) + "}", headerText));

        }
        public static bool ValidateYorN(string entry)
        {
            bool result = false;
            if (entry.ToLower() == "y" || entry.ToLower() == "n")
            {
                result = true;
            }
            return result;
        }

        // Method to get number from console

        public static string GetNumbersFromConsole()
        {
            ConsoleKeyInfo cki;
            bool cont = false;
            string numbers = string.Empty;
            do
            {
                cki = Console.ReadKey(true);
                if (cki.Key == ConsoleKey.Escape)
                {
                    cont = true;
                    numbers = "";
                }
                else if (cki.Key == ConsoleKey.Enter)
                {
                    if (numbers.Length > 0)
                    {
                        cont = true;
                    }
                    else
                    {
                        Console.WriteLine("Please enter an ID that is at least 1 digit.");
                    }
                }
                else if (cki.Key == ConsoleKey.Backspace)
                {
                    Console.Write("\b \b");
                    try
                    {
                        numbers = numbers.Substring(0, numbers.Length - 1);
                    }
                    catch (System.ArgumentOutOfRangeException)
                    {
                        // at the 0 position, can't go any further back
                    }
                }
                else
                {
                    if (char.IsNumber(cki.KeyChar))
                    {
                        numbers += cki.KeyChar.ToString();
                        Console.Write(cki.KeyChar.ToString());
                    }
                }
            } while (!cont);
            return numbers;
        }
        // Method to get text from console.
        public static string GetTextFromConsole(int minLength, bool allowEscape = false)
        {
            ConsoleKeyInfo cki;
            bool cont = false;
            string rtnValue = string.Empty;
            do
            {
                cki = Console.ReadKey(true);
                if (cki.Key == ConsoleKey.Escape)
                {
                    if (allowEscape)
                    {
                        cont = true;
                        rtnValue = "";
                    }
                }
                else if (cki.Key == ConsoleKey.Enter)
                {
                    if (rtnValue.Length >= minLength)
                    {
                        cont = true;
                    }
                    else
                    {
                        Console.WriteLine($"Please enter least {minLength} characters.");
                    }
                }
                else if (cki.Key == ConsoleKey.Backspace)
                {
                    Console.Write("\b \b");
                    try
                    {
                        rtnValue = rtnValue.Substring(0, rtnValue.Length - 1);
                    }
                    catch (System.ArgumentOutOfRangeException)
                    {
                        // at the 0 position, can't go any further back
                    }
                }
                else
                {
                    rtnValue += cki.KeyChar.ToString();
                    Console.Write(cki.KeyChar.ToString());
                }
            } while (!cont);
            return rtnValue;
        }

        public static char CheckForYorN(bool intercept)
        {
            ConsoleKeyInfo cki;
            char entry;
            bool cont = false;
            do
            {
                cki = Console.ReadKey(intercept);
                entry = cki.KeyChar;
                cont = ConsoleHelper.ValidateYorN(entry.ToString());
            } while (!cont);
            return entry;
        }

    }
}
