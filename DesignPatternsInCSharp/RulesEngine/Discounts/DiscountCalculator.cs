﻿using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DesignPatternsInCSharp.RulesEngine.Discounts
{
    public class DiscountCalculator
    {
        public decimal CalculateDiscountPercentage(Customer customer)
        {
            return 0;
        }
    }

    public class DiscountCalculate_CalculateDiscountPercentage
    {
        private DiscountCalculator _calculator = new DiscountCalculator();

        [Fact]
        public void Returns0PctForBasicCustomer()
        {
            var customer = new Customer();

            var result = _calculator.CalculateDiscountPercentage(customer);

            result.Should().Be(0m);
        }

        [Fact]
        public void Returns5PctForCustomersOver65()
        {
            var customer = new Customer { DateOfBirth = DateTime.Today.AddYears(-65).AddDays(-1) };

            var result = _calculator.CalculateDiscountPercentage(customer);

            result.Should().Be(.05m);
        }
    }
}
