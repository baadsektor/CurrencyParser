using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyParser
{
    public class InputValidator
    {
        public bool ValidateInput(string input)
        {
            try
            {
                decimal price = decimal.Parse(input, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture);
                if (price > 999999999.99m || price < 0)
                {
                    Console.WriteLine("Incorrect value. Please enter a value between 0 and 999 999 999,99.");
                    return false;
                }
                return true;
            }
            catch
            {
                Console.WriteLine("Incorrect input. Please enter a numerical value between 0 and 999 999 999,99.");
                return false;
            }
        }
    }
}
