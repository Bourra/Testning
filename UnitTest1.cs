using System;
using Xunit;
using Lektion2;

namespace Lektion2.Tests
{
    public class UnitTest1
    {
        // Testar om kronor kan vara tom
        [Fact]
        public void Test_EmptyKronor()
        {
            var kr = new Kronor();
            Assert.True(kr.isZero());
            Assert.False(kr.isNegative());
            Assert.False(kr.IsPositive());
        }
        // Testar om kronor kan vara negativt
        [Fact]
        public void Test_IsNegativeTrue()
        {
            var kr = new Kronor(-10, 0);
            Assert.False(kr.isZero());
            Assert.True(kr.isNegative());
            Assert.False(kr.IsPositive());
        }
        //Testar om kronor kan vara positivt
        [Fact]
        public void Test_IsPositiveTrue()
        {
            var kr = new Kronor(450, 50);
            Assert.False(kr.isZero());
            Assert.False(kr.isNegative());
            Assert.True(kr.IsPositive());
        }
        // Testar om ˆren r‰knas r‰tt
        [Fact]
        public void Test_÷renPartTrue()
        {

            int expected = 50;
            var actual = new Kronor(5, 50);
            int helaKroner = actual.÷renPart();
            Assert.True(expected == helaKroner);

        }
        // Testar om kronor r‰knas r‰tt
        [Fact]
        public void Test_KronorPartTrue()
        {
            int expected = 5;
            var actual = new Kronor(5, 50);
            int helaKroner = actual.KronorPart();
            Assert.True(expected == helaKroner);

        }
        // Testar om Copy Constructorn kopierar ett v‰rde
        [Fact]
        public void Test_CopyConstructerPart()
        {
            var expected = new Kronor(100, 0);
            var actual = new Kronor(expected);
            Assert.Equal(expected.÷renPart(), actual.÷renPart());

        }
        // Testar om Add metoden fungerar
        [Fact]
        public void Test_AddMethod()
        {
            var expectedKr = 51;
            var expected÷re = 10;
            var money1 = new Kronor(40, 50);
            var money2 = new Kronor(10, 60);
            var money3 = new Kronor(money1.Add(money2));
            Assert.True(money3.KronorPart() == expectedKr && money3.÷renPart() == expected÷re);
        }
        // Testar om Subtract metoden fungerar
        [Fact]
        public void Test_SubtractMethod()
        {
            var expectedKr = 20;
            var expected÷re = 40;
            var money1 = new Kronor(30, 30);
            var money2 = new Kronor(10, 50);
            var money3 = new Kronor(money1.Subtract(money2));
            Assert.True(money3.KronorPart() == expectedKr && money3.÷renPart() == expected÷re);
        }
    }
}
