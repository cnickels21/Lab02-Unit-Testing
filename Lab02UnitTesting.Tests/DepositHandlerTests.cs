﻿using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Lab02UnitTesting.Tests
{
    public class DepositHandlerTests
    {
        [Fact]
        public void Can_add_two_decimals()
        {
            // Arrange
            decimal inputOne = (decimal)243.43;
            decimal inputTwo = (decimal)6.58;

            // Act
            decimal result = UnitTesting.Program.DepositHandler(inputOne, inputTwo);

            // Assert
            Assert.Equal((decimal)250.01, result);
        }

    }
}