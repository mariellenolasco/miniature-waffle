using System;
using Xunit;
using RRModels;
namespace RRTests
{
    public class RestaurantTest
    {
        [Fact]
        public void CityShouldSetValidData()
        {
            // Arrange 
            string city = "San Francisco";
            Restaurant test = new Restaurant();

            //Act
            test.City = city;

            //Assert 
            Assert.Equal(city, test.City);
        }
        [Theory]
        [InlineData("2345678i")]
        [InlineData("beufkjsdhfkjs1")]
        public void CityShouldNotSetInvalidData(string input)
        {
            //Arrange 
            Restaurant test = new Restaurant();

            //Act & Assert
            Assert.Throws<Exception>(() => test.City = input);
        }
    }
}
