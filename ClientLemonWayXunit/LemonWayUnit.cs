using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ClientLemonWayXunit
{
    public class LemonWayUnit
    {
        Soap.SoapServiceSoapClient sopClient = new Soap.SoapServiceSoapClient();


        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(5)]
        [InlineData(8)]
        [InlineData(50)]
        private void FibonaciPosi(int value)
        {
            bool result = sopClient.Fibonacci(value) != -1;
            Assert.True(result);
        }

        [Theory]
        [InlineData(-5)]
        [InlineData(101)]
        [InlineData(200)]
        [InlineData(-504)]
        [InlineData(0)]
        private void FibonaciNeg(int value)
        {
            bool result = sopClient.Fibonacci(value) == -1;
            Assert.True(result);
        }
    }
}
