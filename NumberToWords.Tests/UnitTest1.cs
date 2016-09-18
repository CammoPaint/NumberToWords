using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NumberToWords.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Zero()
        {
            var value = 0;
            var expected = "zero";

            var result = NumberToWords.Helpers.NumberHelper.ConvertNumberToWords(value);

            Assert.AreEqual(expected, result);

        }
        [TestMethod]
        public void Ones()
        {
            var value = 1;
            var expected = "one";

            var result = NumberToWords.Helpers.NumberHelper.ConvertNumberToWords(value);

            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        public void Teens()
        {
            var value = 11;
            var expected = "eleven";

            var result = NumberToWords.Helpers.NumberHelper.ConvertNumberToWords(value);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Tens()
        {
            var value = 20;
            var expected = "twenty";

            var result = NumberToWords.Helpers.NumberHelper.ConvertNumberToWords(value);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TenAndOnes()
        {
            var value = 25;
            var expected = "twenty-five";

            var result = NumberToWords.Helpers.NumberHelper.ConvertNumberToWords(value);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Hundred()
        {
            var value = 100;
            var expected = "one hundred";

            var result = NumberToWords.Helpers.NumberHelper.ConvertNumberToWords(value);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Hundreds()
        {
            var value = 101;
            var expected = "one hundred and one";

            var result = NumberToWords.Helpers.NumberHelper.ConvertNumberToWords(value);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void HundredsAndTens()
        {
            var value = 121;
            var expected = "one hundred and twenty-one";

            var result = NumberToWords.Helpers.NumberHelper.ConvertNumberToWords(value);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Thousand()
        {
            var value = 1000;
            var expected = "one thousand";

            var result = NumberToWords.Helpers.NumberHelper.ConvertNumberToWords(value);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Thousands()
        {
            var value = 1001;
            var expected = "one thousand and one";

            var result = NumberToWords.Helpers.NumberHelper.ConvertNumberToWords(value);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ThousandsAndHundred()
        {
            var value = 1101;
            var expected = "one thousand one hundred and one";

            var result = NumberToWords.Helpers.NumberHelper.ConvertNumberToWords(value);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TenThousand()
        {
            var value = 10000;
            var expected = "ten thousand";

            var result = NumberToWords.Helpers.NumberHelper.ConvertNumberToWords(value);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TenThousands()
        {
            var value = 10001;
            var expected = "ten thousand and one";

            var result = NumberToWords.Helpers.NumberHelper.ConvertNumberToWords(value);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TenThousandAndHundreds()
        {
            var value = 10101;
            var expected = "ten thousand one hundred and one";

            var result = NumberToWords.Helpers.NumberHelper.ConvertNumberToWords(value);

            Assert.AreEqual(expected, result);
        }


        [TestMethod]
        public void HundredThousand()
        {
            var value = 100000;
            var expected = "one hundred thousand";

            var result = NumberToWords.Helpers.NumberHelper.ConvertNumberToWords(value);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Million()
        {
            var value = 1000000;
            var expected = "one million";

            var result = NumberToWords.Helpers.NumberHelper.ConvertNumberToWords(value);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Millions()
        {
            var value = 1000001;
            var expected = "one million and one";

            var result = NumberToWords.Helpers.NumberHelper.ConvertNumberToWords(value);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void MillionsAndHundreds()
        {
            var value = 1000101;
            var expected = "one million one hundred and one";

            var result = NumberToWords.Helpers.NumberHelper.ConvertNumberToWords(value);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void MillionsAndThousands()
        {
            var value = 1001000;
            var expected = "one million one thousand";

            var result = NumberToWords.Helpers.NumberHelper.ConvertNumberToWords(value);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void MillionsAndHundredThousands()
        {
            var value = 1100000;
            var expected = "one million one hundred thousand";

            var result = NumberToWords.Helpers.NumberHelper.ConvertNumberToWords(value);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Currency()
        {
            var expected = "one dollar and fifty cents";

            var result = NumberToWords.Helpers.NumberHelper.ConvertNumberToCurrency(1.50,"dollar","cent");

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CurrencyDollars()
        {
            var expected = "one hundred dollars";

            var result = NumberToWords.Helpers.NumberHelper.ConvertNumberToCurrency(100.00, "dollar", "cent");

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CurrencyCents()
        {
            var expected = "twenty-seven cents";

            var result = NumberToWords.Helpers.NumberHelper.ConvertNumberToCurrency(0.27, "dollar", "cent");

            Assert.AreEqual(expected, result);
        }
    }
}
