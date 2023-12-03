using Carre.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarreUnitTest.Services
{
    public class CarreServiceTest
    {

        [Fact]
        public void GetColorCarre_should_Return_1_If_1_Passed()
        {
            // Arrange
              var careService = new CarreService();
            // Act 
            var result = careService.GetColorCarre(1);
            // Assert
            Assert.Equal("1", result);
        }

        [Fact]
        public void GetColorCarre_should_Return_2_If_2_Passed()
        {
            // Arrange
            var careService = new CarreService();
            // Act 
            var result = careService.GetColorCarre(2);
            // Assert
            Assert.Equal("2", result);
        }

        [Fact]
        public void GetColorCarre_should_Return_Verte_If_3_Passed()
        {
            // Arrange
            var careService = new CarreService();
            // Act 
            var result = careService.GetColorCarre(3);
            // Assert
            Assert.Equal("Verte", result);
        }

        [Fact]
        public void GetColorCarre_should_Return_Bleu_If_5_Passed()
        {
            // Arrange
            var careService = new CarreService();
            // Act 
            var result = careService.GetColorCarre(5);
            // Assert
            Assert.Equal("Bleu", result);
        }


        [Fact]
        public void GetColorCarre_should_Return_Jaune_If_15_Passed()
        {
            // Arrange
            var careService = new CarreService();
            // Act 
            var result = careService.GetColorCarre(15);
            // Assert
            Assert.Equal("Jaune", result);
        }

    
    }
}
