﻿using Carre.Services;
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
        CarreService _carreService;
        public CarreServiceTest()
        {
            _carreService = new CarreService();
        }

        [Fact]
        public void GetColorCarre_should_Return_1_If_1_Passed()
        {
            // Act 
            var result = _carreService.GetColorCarre(1);
            // Assert
            result.Should().Be("1");
        }

        [Fact]
        public void GetColorCarre_should_Return_2_If_2_Passed()
        {
            // Arrange
            // Act 
            var result = _carreService.GetColorCarre(2);
            // Assert
            result.Should().Be("2");
        }

        [Fact]
        public void GetColorCarre_should_Return_Verte_If_3_Passed()
        {
            // Arrange
            // Act 
            var result = _carreService.GetColorCarre(3);
            // Assert
            result.Should().Be("Verte");
        }

        [Fact]
        public void GetColorCarre_should_Return_Bleu_If_5_Passed()
        {
            // Arrange
            // Act 
            var result = _carreService.GetColorCarre(5);
            // Assert
            result.Should().Be("Bleu");
        }


        [Fact]
        public void GetColorCarre_should_Return_Jaune_If_15_Passed()
        {
            // Arrange
            // Act 
            var result = _carreService.GetColorCarre(15);
            // Assert
            result.Should().Be("Jaune");
        }

        [Fact]
        public void GetListeColorsCarres_should_Return_NotEmpty_If_max_Passed()
        {
            // Arrange
            // Act 
            var result = _carreService.GetListeColorsCarres(15);
            // Assert
            result.Should().NotBeEmpty();
        }

        [Fact]
        public void GetListeColorsCarres_should_throwArgumentException_When_Max_Is_LowerOrEqual_To_Zero()
        {

            // Act 
            Action act = () => _carreService.GetListeColorsCarres(-15);
            // Assert
            act.Should().Throw<ArgumentException>();

        }

    }
}
