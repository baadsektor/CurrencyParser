using CurrencyParser.Parser;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CurrencyParser.Tests
{
    [TestClass]
    public class NumberParserTests
    {
        [TestMethod]
        public void NumberParser_Correctly_Parses_1()
        {
            NumberParser numberParser = new NumberParser();
            Assert.AreEqual(numberParser.ParseNumber(1), "one ");
        }

        [TestMethod]
        public void NumberParser_Correctly_Parses_10()
        {
            NumberParser numberParser = new NumberParser();
            Assert.AreEqual(numberParser.ParseNumber(10), "ten ");
        }

        [TestMethod]
        public void NumberParser_Correctly_Parses_13()
        {
            NumberParser numberParser = new NumberParser();
            Assert.AreEqual(numberParser.ParseNumber(13), "thirteen ");
        }

        [TestMethod]
        public void NumberParser_Correctly_Parses_20()
        {
            NumberParser numberParser = new NumberParser();
            Assert.AreEqual(numberParser.ParseNumber(20), "twenty ");
        }

        [TestMethod]
        public void NumberParser_Correctly_Parses_24()
        {
            NumberParser numberParser = new NumberParser();
            Assert.AreEqual(numberParser.ParseNumber(24), "twenty-four ");
        }

        [TestMethod]
        public void NumberParser_Correctly_Parses_99()
        {
            NumberParser numberParser = new NumberParser();
            Assert.AreEqual(numberParser.ParseNumber(99), "ninety-nine ");
        }

        [TestMethod]
        public void NumberParser_Correctly_Parses_100()
        {
            NumberParser numberParser = new NumberParser();
            Assert.AreEqual(numberParser.ParseNumber(100), "one hundred ");
        }

        [TestMethod]
        public void NumberParser_Correctly_Parses_101()
        {
            NumberParser numberParser = new NumberParser();
            Assert.AreEqual(numberParser.ParseNumber(101), "one hundred one ");
        }

        [TestMethod]
        public void NumberParser_Correctly_Parses_210()
        {
            NumberParser numberParser = new NumberParser();
            Assert.AreEqual(numberParser.ParseNumber(210), "two hundred ten ");
        }

        [TestMethod]
        public void NumberParser_Correctly_Parses_215()
        {
            NumberParser numberParser = new NumberParser();
            Assert.AreEqual(numberParser.ParseNumber(215), "two hundred fifteen ");
        }

        [TestMethod]
        public void NumberParser_Correctly_Parses_220()
        {
            NumberParser numberParser = new NumberParser();
            Assert.AreEqual(numberParser.ParseNumber(220), "two hundred twenty ");
        }

        [TestMethod]
        public void NumberParser_Correctly_Parses_350()
        {
            NumberParser numberParser = new NumberParser();
            Assert.AreEqual(numberParser.ParseNumber(350), "three hundred fifty ");
        }

        [TestMethod]
        public void NumberParser_Correctly_Parses_476()
        {
            NumberParser numberParser = new NumberParser();
            Assert.AreEqual(numberParser.ParseNumber(476), "four hundred seventy-six ");
        }

        [TestMethod]
        public void NumberParser_Correctly_Parses_999()
        {
            NumberParser numberParser = new NumberParser();
            Assert.AreEqual(numberParser.ParseNumber(999), "nine hundred ninety-nine ");
        }
    }
}
