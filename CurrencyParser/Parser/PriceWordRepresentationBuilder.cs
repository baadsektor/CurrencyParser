using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyParser.Parser
{
    public class PriceWordRepresentationBuilder
    {
        private StringBuilder wordRepresentationStringBuilder;
        private NumberParser numberParser;

        public PriceWordRepresentationBuilder(NumberParser numberParser)
        {
            this.wordRepresentationStringBuilder = new StringBuilder();
            this.numberParser = numberParser;
        }

        public string Build(decimal price)
        {
            if (price == 0)
            {
                return "zero dollars";
            }

            BuildDollars(price);
            BuildCents(price);

            return this.wordRepresentationStringBuilder.ToString();
        }

        private void BuildDollars(decimal price)
        {
            ParseMillions(price);
            ParseThousands(price);
            ParsePriceAfterThousands(price);
            AppendDollars(price);
        }

        private void BuildCents(decimal price)
        {
            int cents = (int)(GetCents(price));
            if (cents > 0)
            {
                this.wordRepresentationStringBuilder.Append(this.numberParser.ParseNumber(cents))
                    .Append(GetCurrencyInSingularOrPlural(cents, Consts.Cent));
            }
        }

        #region Dollar methods

        private void ParseMillions(decimal price)
        {
            int millions = (int)price / Consts.Numbers.OneMillion;
            if (millions > 0)
            {
                this.wordRepresentationStringBuilder.Append(numberParser.ParseNumber(millions))
                    .Append(Consts.Million)
                    .Append(Consts.Whitespace);
            }
        }

        private void ParseThousands(decimal price)
        {
            var priceAfterMillions = GetPriceAfterMillions(price);
            int thousands = (int)priceAfterMillions / Consts.Numbers.OneThousand;
            if (thousands > 0)
            {
                this.wordRepresentationStringBuilder.Append(numberParser.ParseNumber(thousands))
                    .Append(Consts.Thousand)
                    .Append(Consts.Whitespace);
            }
        }

        private void ParsePriceAfterThousands(decimal price)
        {
            var priceAfterThousands = GetPriceAfterThousands(price);
            if (price > 0)
            {
                this.wordRepresentationStringBuilder.Append(numberParser.ParseNumber((int)priceAfterThousands));
            }
        }

        private void AppendDollars(decimal price)
        {
            var dollars = (int)price;
            if (dollars > 0)
            {
                this.wordRepresentationStringBuilder.Append(GetCurrencyInSingularOrPlural(dollars, Consts.Dollar));
                if (GetCents(price) > 0)
                {
                    this.wordRepresentationStringBuilder.Append(Consts.And);
                }
            }
        }

        #endregion

        #region Calculations 

        private static decimal GetPriceAfterMillions(decimal price)
        {
            return price % Consts.Numbers.OneMillion;
        }

        private static decimal GetPriceAfterThousands(decimal price)
        {
            decimal priceAfterMillions = GetPriceAfterMillions(price);
            return priceAfterMillions % Consts.Numbers.OneThousand;
        }

        private static decimal GetCents(decimal price)
        {
            return price % 1.0M * 100;
        }

        private static string GetCurrencyInSingularOrPlural(int cents, string currency)
        {
            return cents == 1 ? currency : $"{currency}s";
        }

        #endregion
    }
}
