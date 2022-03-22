using System;
using System.ComponentModel.DataAnnotations;
using Xunit;
using FluentAssertions;


namespace CalculadoraApp.Tests
{
    public class CalcularaTests
    {
        private Calculadora _calculadora;

        public CalcularaTests()
        {
            _calculadora = new Calculadora();
        }

        [Theory]
        [InlineData("AA-BB-00", "AABB00")]
        [InlineData("AA BB 00", "AABB00")]
        [InlineData(null, "")]
        public void Test_Matricula(string input, string expected)
        {
            // Arrange

            // Act
            var actual = ProcessaMatricula(input);

            // Assert
            Assert.Equal(expected, actual);
        }


        [Theory]
        [InlineData(6, 1, 2, 3)]
        [InlineData(60, 10, 2, 3)]
        [InlineData(0, 1, 2, 3, 200, 0)]
        public void Multiply_N_Numbers_Success(int expected, params int[] inputs)
        {
            var actual = _calculadora.Multiply(inputs);
            actual.Should().Be(expected);
        }

        [Fact]
        public void Sum_TwoNumbers_Success()
        {
            var expected = 10 + 35;
            var result = _calculadora.Sum(10, 35);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Subtract_TwoNumbers_Success()
        {
            // Arrange
            var num1 = 100;
            var num2 = 58;
            var expected = num1 - num2;

            // Act
            var actual = _calculadora.Subtract(num1, num2);

            // Assert
            Assert.True(expected == actual);
        }



        [Fact]
        public void Divide_ByZero_ThrowException()
        {
            Assert.Throws<Exception>(
                () => _calculadora.Divide(10, 0));
        }
        
        [Fact]
        public void Divide_TwoNumbers_ResultOk()
        {
            var actual = _calculadora.Divide(10, 2);

            actual.Should().Be(5);
        }

        [Fact]
        public void MinMax_Success()
        {
            var expected = (1, 52);

            var actual = _calculadora.MinMax(1, 2, 3, 4, 5, 52, 12);
            
            var (min, _) = _calculadora.MinMax(1, 2, 3, 4, 5, 52, 12);

            Assert.Equal(expected, actual);
        }


        private string ProcessaMatricula(string input)
        {
            return input == null ? "" : input.Replace("-", "").Replace(" ", "");
        }
    }
}