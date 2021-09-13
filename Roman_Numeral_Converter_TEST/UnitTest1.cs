using System;
using Xunit;

namespace TestProject1
{
    public class Roman_Number_Conversion_Test
    {
        [Fact]
        public void Test_I_Conversion()
        {
            var subject = new Roman_Numeral_TEST.Roman_Numeral_Converter();

            var result = subject.convert(@"I");

            Assert.Equal(1u, result);
        }

        [Fact]
        public void Test_II_Conversion()
        {
            var subject = new Roman_Numeral_TEST.Roman_Numeral_Converter();

            var result = subject.convert(@"II");

            Assert.Equal(2u, result);
        }

        [Fact]
        public void Test_III_Conversion()
        {
            var subject = new Roman_Numeral_TEST.Roman_Numeral_Converter();

            var result = subject.convert(@"III");

            Assert.Equal(3u, result);
        }

        [Fact]
        public void Test_V_Conversion()
        {
            var subject = new Roman_Numeral_TEST.Roman_Numeral_Converter();

            var result = subject.convert(@"V");

            Assert.Equal(5u, result);
        }

        [Fact]
        public void Test_IV_Conversion()
        {
            var subject = new Roman_Numeral_TEST.Roman_Numeral_Converter();

            var result = subject.convert(@"IV");

            Assert.Equal(4u, result);
        }

        [Fact]
        public void Test_VI_Conversion()
        {
            var subject = new Roman_Numeral_TEST.Roman_Numeral_Converter();

            var result = subject.convert(@"VI");

            Assert.Equal(6u, result);
        }

        [Fact]
        public void Test_VII_Conversion()
        {
            var subject = new Roman_Numeral_TEST.Roman_Numeral_Converter();

            var result = subject.convert(@"VII");

            Assert.Equal(7u, result);
        }

        [Fact]
        public void Test_X_Conversion()
        {
            var subject = new Roman_Numeral_TEST.Roman_Numeral_Converter();

            var result = subject.convert(@"X");

            Assert.Equal(10u, result);
        }

        [Fact]
        public void Test_L_Conversion()
        {
            var subject = new Roman_Numeral_TEST.Roman_Numeral_Converter();

            var result = subject.convert(@"L");

            Assert.Equal(50u, result);
        }

        [Fact]
        public void Test_XL_Conversion()
        {
            var subject = new Roman_Numeral_TEST.Roman_Numeral_Converter();

            var result = subject.convert(@"XL");

            Assert.Equal(40u, result);
        }

        [Fact]
        public void Test_LIX_Conversion()
        {
            var subject = new Roman_Numeral_TEST.Roman_Numeral_Converter();

            var result = subject.convert(@"LIX");

            Assert.Equal(59u, result);
        }

        [Fact]
        public void Test_XLIX_Conversion()
        {
            var subject = new Roman_Numeral_TEST.Roman_Numeral_Converter();

            var result = subject.convert(@"XLIX");

            Assert.Equal(49u, result);
        }

        [Fact]
        public void Test_MMMCMXCIX_Conversion()
        {
            var subject = new Roman_Numeral_TEST.Roman_Numeral_Converter();

            var result = subject.convert(@"MMMCMXCIX");

            Assert.Equal(3999u, result);
        }
    }
}
