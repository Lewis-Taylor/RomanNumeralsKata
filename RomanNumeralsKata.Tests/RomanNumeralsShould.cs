using FluentAssertions;
using NUnit.Framework;

namespace RomanNumeralsKata.Tests
{
    [TestFixture]
    public class RomanNumeralsShould
    {
        [TestCase(1,"I")]
        [TestCase(2,"II")]
        [TestCase(3,"III")]
        [TestCase(4,"IV")]
        [TestCase(5,"V")]
        [TestCase(6,"VI")]
        [TestCase(7,"VII")]
        [TestCase(8,"VIII")]
        [TestCase(9,"IX")]
        [TestCase(10,"X")]
        [TestCase(11,"XI")]
        [TestCase(12,"XII")]
        [TestCase(13,"XIII")]
        [TestCase(14,"XIV")]
        [TestCase(15,"XV")]
        [TestCase(40,"XL")]
        [TestCase(41,"XLI")]
        [TestCase(42,"XLII")]
        [TestCase(45,"XLV")]
        [TestCase(50,"L")]
        [TestCase(51,"LI")]
        [TestCase(52,"LII")]
        [TestCase(55,"LV")]
        [TestCase(70,"LXX")]
        public void ReturnRomanNumeral_WhenConverting_GivenTheInputIsAnArabicNumber(int arabicNumber, string expectedRomanNumeral)
        {
            var romanNumeral = RomanNumerals.Convert(arabicNumber);
            romanNumeral.Should().Be(expectedRomanNumeral);
        }
    }
}
