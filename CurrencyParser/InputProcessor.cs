using CurrencyParser.Parser;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyParser
{
    public class InputProcessor
    {
        private InputValidator inputValidator;

        public InputProcessor(InputValidator inputValidator)
        {
            this.inputValidator = inputValidator;
        }

        public void ProcessInput(string input)
        {
            string formattedInput = input.Replace(Consts.Whitespace, string.Empty).Replace(Consts.Comma, CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator);
            if (this.inputValidator.ValidateInput(formattedInput))
            {
                decimal price = decimal.Parse(formattedInput, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture);

                PriceWordRepresentationBuilder priceWordRepresentationBuilder = new PriceWordRepresentationBuilder(new NumberParser());
                Console.WriteLine(priceWordRepresentationBuilder.Build(price));
            }
        }
    }
}
