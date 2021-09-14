using System;
using Xunit;
using System.Linq;
using System.Collections.Generic;

namespace RomanNumeralConversionTest
{
    public class RomanNumeralConversionStep
    {
        [Fact]
        public void Test_I_Conversion() => Assert.Equal(1u, actual: RomanNumeral.RomanNumeralConverter.Convert(@"I"));

        [Fact]
        public void Test_II_Conversion() => Assert.Equal(2u, actual: RomanNumeral.RomanNumeralConverter.Convert(@"II"));

        [Fact]
        public void Test_III_Conversion() => Assert.Equal(3u, actual: RomanNumeral.RomanNumeralConverter.Convert(@"III"));

        [Fact]
        public void Test_V_Conversion() => Assert.Equal(5u, actual: RomanNumeral.RomanNumeralConverter.Convert(@"V"));

        [Fact]
        public void Test_IV_Conversion() => Assert.Equal(4u, actual: RomanNumeral.RomanNumeralConverter.Convert(@"IV"));

        [Fact]
        public void Test_VI_Conversion() => Assert.Equal(6u, actual: RomanNumeral.RomanNumeralConverter.Convert(@"VI"));

        [Fact]
        public void Test_VII_Conversion() => Assert.Equal(7u, actual: RomanNumeral.RomanNumeralConverter.Convert(@"VII"));

        [Fact]
        public void Test_X_Conversion() => Assert.Equal(10u, actual: RomanNumeral.RomanNumeralConverter.Convert(@"X"));

        [Fact]
        public void Test_L_Conversion() => Assert.Equal(50u, actual: RomanNumeral.RomanNumeralConverter.Convert(@"L"));

        [Fact]
        public void Test_XL_Conversion() => Assert.Equal(40u, actual: RomanNumeral.RomanNumeralConverter.Convert(@"XL"));

        [Fact]
        public void Test_LIX_Conversion() => Assert.Equal(59u, actual: RomanNumeral.RomanNumeralConverter.Convert(@"LIX"));

        [Fact]
        public void Test_XLIX_Conversion() => Assert.Equal(49u, actual: RomanNumeral.RomanNumeralConverter.Convert(@"XLIX"));

        [Fact]
        public void Test_MMMCMXCIX_Conversion() => Assert.Equal(3999u, actual: RomanNumeral.RomanNumeralConverter.Convert(@"MMMCMXCIX"));

        [Fact]
        public void Test_Garabage_Conversion() => Assert.Throws<ArgumentException>(() => { RomanNumeral.RomanNumeralConverter.Convert(@"1ywArDg97"); });

        [Fact]
        public void Positive_Test_Roman_Format_Validity()
        {
            var positive_test_list = new List<string>
            {
                @"MMMCMXCIX"
                ,@"MMMDCCCLXXXVIII"
            };

            foreach (var test_string in positive_test_list)
            {
                Assert.True(RomanNumeral.RomanNumeralConverter.IsValid(test_string));
            }
        }

        [Fact]
        public void Negative_Test_Roman_Format_Validity()
        {
            var negative_test_list = new List<string>
            {
                @"+kh0J@ccy"
                ,@"1ywArDg97"
                ,@"m1zWQ0lH@"
                ,@"lf65L~e5V"
                ,@"y7p~poklC"
                ,@"YG3q9BN2O"
                ,@"-pUyOCA7!"
                ,@"9+mwn2zyC"
                ,@"RnLL3vyNA"
                ,@"L-n5sa2jP"
                ,@"BAsn?zrsp"
                ,@"gskA8L?+P"
                ,@"C03pAAB6!"
                ,@"aDUM-Dnyx"
                ,@"avpdlLFRl"
                ,@"hKDb6wKz0"
                ,@"ccAsmI3Qo"
                ,@"IK~-Ey1sj"
                ,@" wau3VYjm"
                ,@"CD3p6j 8j"
                ,@""
                //,@"IIIIIIIIII"
                ,@"MMMDCCCLXXXVIIII"
            };

            foreach (var test_string in negative_test_list)
            {
                Assert.False(RomanNumeral.RomanNumeralConverter.IsValid(test_string));
            }
        }
    }
}