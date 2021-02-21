using CurrencyParser.Parser;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyParser.Tests
{
    [TestClass]
    public class PriceWordRepresentationBuilderTests
    {
        [TestMethod]
        public void BuildCurrencyString_Correctly_Parses_1_Dollar()
        {
            decimal price = 1.0m;
            var priceWordRepresentationBuilder = new PriceWordRepresentationBuilder(new NumberParser());
            Assert.AreEqual("one dollar", priceWordRepresentationBuilder.Build(price));
        }

        [TestMethod]
        public void BuildCurrencyString_Correctly_Parses_2_Dollars()
        {
            decimal price = 2.0m;
            var priceWordRepresentationBuilder = new PriceWordRepresentationBuilder(new NumberParser());
            Assert.AreEqual("two dollars", priceWordRepresentationBuilder.Build(price));
        }

        [TestMethod]
        public void BuildCurrencyString_Correctly_Parses_10_Dollars()
        {
            decimal price = 10.0m;
            var priceWordRepresentationBuilder = new PriceWordRepresentationBuilder(new NumberParser());
            Assert.AreEqual("ten dollars", priceWordRepresentationBuilder.Build(price));
        }

        [TestMethod]
        public void BuildCurrencyString_Correctly_Parses_1_Cent()
        {
            decimal price = 0.01m;
            var priceWordRepresentationBuilder = new PriceWordRepresentationBuilder(new NumberParser());
            Assert.AreEqual("one cent", priceWordRepresentationBuilder.Build(price));
        }

        [TestMethod]
        public void BuildCurrencyString_Correctly_Parses_2_Cents()
        {
            decimal price = 0.02m;
            var priceWordRepresentationBuilder = new PriceWordRepresentationBuilder(new NumberParser());
            Assert.AreEqual("two cents", priceWordRepresentationBuilder.Build(price));
        }

        [TestMethod]
        public void BuildCurrencyString_Correctly_Parses_25_Dollars_And_99_Cents()
        {
            decimal price = 25.99m;
            var priceWordRepresentationBuilder = new PriceWordRepresentationBuilder(new NumberParser());
            Assert.AreEqual("twenty-five dollars and ninety-nine cents", priceWordRepresentationBuilder.Build(price));
        }

        [TestMethod]
        public void BuildCurrencyString_Correctly_Parses_999Million999Thousand999Dollars()
        {
            decimal price = 999999999.99m;
            var priceWordRepresentationBuilder = new PriceWordRepresentationBuilder(new NumberParser());
            Assert.AreEqual("nine hundred ninety-nine million nine hundred ninety-nine thousand nine hundred ninety-nine dollars and ninety-nine cents", priceWordRepresentationBuilder.Build(price));
        }

        [TestMethod]
        public void BuildCurrencyString_Correctly_Parses_Zero_As_Zero_Dollars()
        {
            decimal price = 0;
            var priceWordRepresentationBuilder = new PriceWordRepresentationBuilder(new NumberParser());
            Assert.AreEqual("zero dollars", priceWordRepresentationBuilder.Build(price));
        }
    }
}
