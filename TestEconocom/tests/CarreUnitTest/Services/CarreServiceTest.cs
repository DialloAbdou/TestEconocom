using Carre.Services;
using FluentAssertions;
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
        CarreService carreService;
        public CarreServiceTest()
        {
            carreService = new CarreService();
        }

        [Fact]
        public void GetColorCarre_should_Return_1_If_1_Passed()
        {
            // Act 
            var result = carreService.GetColorCarre(1);
            // Assert
            result.Should().Be("1");
        }

        [Fact]
        public void GetColorCarre_should_Return_2_If_2_Passed()
        {
            // Arrange
            // Act 
            var result = carreService.GetColorCarre(2);
            // Assert
            result.Should().Be("2");
        }

        [Fact]
        public void GetColorCarre_should_Return_Verte_If_3_Passed()
        {
            // Arrange
            // Act 
            var result = carreService.GetColorCarre(3);
            // Assert
            result.Should().Be("Verte");
        }

        [Fact]
        public void GetColorCarre_should_Return_Bleu_If_5_Passed()
        {
            // Arrange
            // Act 
            var result = carreService.GetColorCarre(5);
            // Assert
            result.Should().Be("Bleu");
        }


        [Fact]
        public void GetColorCarre_should_Return_Jaune_If_15_Passed()
        {
            // Arrange
            // Act 
            var result = carreService.GetColorCarre(15);
            // Assert
            result.Should().Be("Jaune");
        }


    }
}
