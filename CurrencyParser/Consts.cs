using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyParser
{
    public class Consts
    {
        public static readonly string[] Units = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        public static readonly string[] Teens = { "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
        public static readonly Dictionary<int, string> Tens = new Dictionary<int, string>()
        {
            {2, "twenty" },
            {3, "thirty" },
            {4, "forty" },
            {5, "fifty" },
            {6, "sixty" },
            {7, "seventy" },
            {8, "eighty" },
            {9, "ninety" }
        };
        public const string Hundred = "hundred";
        public const string Thousand = "thousand";
        public const string Million = "million";

        public const string Dollar = "dollar";
        public const string Cent = "cent";
        public const string And = " and ";
        public const string Whitespace = " ";
        public const string Comma = ",";
        public class Numbers
        {
            public const int OneMillion = 1000000;
            public const int OneThousand = 1000;
        }
    }
}
