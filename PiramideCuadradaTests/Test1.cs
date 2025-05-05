using Practico.Entidades;
using System.ComponentModel.DataAnnotations;

namespace PiramideCuadradaTests
{
    [TestClass]
    public  class PiramideCuadradaTests
    {
        [TestMethod]
        public void CalcularApotema_DevuelveValorEsperado()
        {
            // Arrange
            var piramide = new PiramideCuadrada(6, 12);

            // Act
            double apotema = piramide.CalcularApotema();

            // Assert
            Assert.AreEqual(12.36931687685298, apotema, 0.00001);
        }
        [TestMethod]
        public void CalcularVolumen_DevuelveValorEsperado()
        {
            // Arrange
            var piramide = new PiramideCuadrada(6, 12);

            // Act
            double volumen = piramide.CalcularVolumen();

            // Assert
            Assert.AreEqual(144, volumen, 0.00001);
        }

        [TestMethod]
        public void CalcularArea_DevuelveValorEsperado()
        {
            // Arrange
            var piramide = new PiramideCuadrada(6, 12);

            // Act
            double area = piramide.CalcularArea();

            // Assert
            Assert.AreEqual(184.43180252223578, area, 0.00001);
        }

        [TestMethod]
        public void Validar_ValoresNegativos_DebeRetornarErrores()
        {
            // Arrange
            var piramide = new PiramideCuadrada(-5, -10);
            var resultadosValidacion = new List<ValidationResult>();
            var contexto = new ValidationContext(piramide);

            // Act
            bool esValido = Validator.TryValidateObject(piramide, contexto, resultadosValidacion, true);

            // Assert
            Assert.IsFalse(esValido);
            Assert.IsTrue(resultadosValidacion.Exists(r => r.ErrorMessage.Contains("El lado de la base debe ser mayor a 0.")));
            Assert.IsTrue(resultadosValidacion.Exists(r => r.ErrorMessage.Contains("La altura debe ser mayor a 0.")));
        }
    }
}
