using Microsoft.VisualStudio.TestPlatform.TestHost;
using System;
using Xunit;

namespace Lab02UnitTesting.Tests
{
    public class Lab02UnitTesting
    {
        [Fact]
        public void Checking_the_main()
        {
            int input = 1;

            int result = UnitTesting.Program.TestingTheTest(input);

            Assert.Equal(2, result);
        }
    }
}
