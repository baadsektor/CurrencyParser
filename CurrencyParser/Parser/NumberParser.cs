using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyParser.Parser
{
    public class NumberParser
    {
        public string ParseNumber(int number)
        {
            StringBuilder sb = new StringBuilder();
            ParseHundreds(sb, number);

            int remainderToParse = GetTwoDigitNumber(number);
            ParseTens(sb, remainderToParse);
            ParseTeensAndUnits(sb, remainderToParse);
            return sb.ToString();
        }

        private static void ParseHundreds(StringBuilder sb, int number)
        {
            if (number >= 100)
            {
                int hundreds = number / 100;
                sb.Append($"{Consts.Units[hundreds]} {Consts.Hundred}").Append(Consts.Whitespace);
            }
        }

        private static void ParseTens(StringBuilder sb, int number)
        {
            if (number > 19)
            {
                int tens = GetTens(number);
                sb.Append(Consts.Tens[tens]);

                int remainingUnits = GetTeensOrRemainingUnits(number);
                if (remainingUnits > 0)
                {
                    sb.Append($"-{Consts.Units[remainingUnits]}");
                }

                sb.Append(Consts.Whitespace);
            }
        }

        private static void ParseTeensAndUnits(StringBuilder sb, int number)
        {
            if (number < 20 && number > 0)
            {
                if (number > 9)
                {
                    sb.Append(Consts.Teens[GetTeensOrRemainingUnits(number)]).Append(Consts.Whitespace);
                }
                else
                {
                    sb.Append(Consts.Units[number]).Append(Consts.Whitespace);
                }
            }
        }

        private static int GetTens(int number)
        {
            return number / 10;
        }

        private static int GetTwoDigitNumber(int number)
        {
            return number % 100;
        }

        private static int GetTeensOrRemainingUnits(int number)
        {
            return number % 10;
        }

    }
}
