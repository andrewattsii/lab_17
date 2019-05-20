using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Lab17
{
    public class PrimeNumberTest
    {
        [Fact]
        public void Test2()
        {
            int actual = PrimeNumber.GetPrimeNumber(1);
            int expected = 2;
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Test5()
        {
            int actual = PrimeNumber.GetPrimeNumber(5);
            int expected = 11;
            Assert.Equal(expected, actual);
        }

        public void Test10()
        {
            int actual = PrimeNumber.GetPrimeNumber(10);
            int expected = 31;
            Assert.Equal(expected, actual);
        }

    }
}