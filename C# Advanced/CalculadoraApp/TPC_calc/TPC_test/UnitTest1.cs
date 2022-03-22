using FluentAssertions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using TPC_calc;
using Xunit;
using static System.Math;

namespace TPC_test
{
    public class UnitTest1
    {
        private readonly Calculator _calculadora;
        public UnitTest1() 
        {
            _calculadora = new Calculator();
        }

        [Fact]
        public void AreaRectangle()
        {
            var l = 10;
            var w = 20;
            var result = _calculadora.AreaRectangle(l, w);

            Assert.Equal(200, result);

            result.Should().Be(result);
        }

        [Fact]
        public void AreaCircle()
        {
            var r = 10;
            var result = _calculadora.AreaCirculo(r);

            result.Should().Be(result);
        }

        public void SumNToAllElements()
        {
            var n = 5;
            List<double> teste = new List<double>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var result = _calculadora.SumarACollection(n, teste);

            result.Should().BeSameAs(result);
        }

        public static IEnumerable<object[]> TestData()
        {
            yield return new object[] { 50, new int[] { 10,5 } };
            yield return new object[] { 125, new int[] { 5, 5, 5 } };
            yield return new object[] { 15, new int[] { 5, 3 } };
        }

        [Fact]
        public void Multiply_N_Numbers_Success()
        {
            Calculator calcula = new Calculator { };
            int x = 10, y = 2, z = 3;
            int expected = x * y * z;

            var actual = _calculadora.Multiply(x, y, z);


            actual.Should().Be(expected);
        }



    }
}