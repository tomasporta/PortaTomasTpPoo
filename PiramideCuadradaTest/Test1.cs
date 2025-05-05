using Practico.Entidades;
using System.ComponentModel.DataAnnotations;

namespace PiramideCuadradaTest
{
    [TestClass]
    public class PiramideCuadradaTests
    {
        [TestMethod]
        public void CalcularApotema_ValoresCorrectos_CalculoEsperado()
        {
            var piramide = new PiramideCuadrada(6, 12);
            double apotemaEsperado = Math.Sqrt(Math.Pow(6 / 2.0, 2) + Math.Pow(12, 2));
            Assert.AreEqual(apotemaEsperado, piramide.Apotema, 0.0001);
        }

        [TestMethod]
        public void CalcularArea_ValoresCorrectos_CalculoEsperado()
        {
            var piramide = new PiramideCuadrada(6, 12);
            double areaEsperada = Math.Pow(6, 2) + (2 * 6 * piramide.Apotema);
            Assert.AreEqual(areaEsperada, piramide.GetArea(), 0.0001);
        }

        [TestMethod]
        public void CalcularVolumen_ValoresCorrectos_CalculoEsperado()
        {
            var piramide = new PiramideCuadrada(6, 12);
            double volumenEsperado = (Math.Pow(6, 2) * 12) / 3;
            Assert.AreEqual(volumenEsperado, piramide.GetVolumen(), 0.0001);
        }

        [TestMethod]
        public void ValidarDatos_ValoresInvalidos_MuestraErrores()
        {
            var piramide = new PiramideCuadrada(-5, 0);
            var context = new ValidationContext(piramide);
            var resultados = new List<ValidationResult>();
            var esValido = Validator.TryValidateObject(piramide, context, resultados, true);

            Assert.IsFalse(esValido);
            Assert.AreEqual(2, resultados.Count); // Dos errores esperados
        }
    }
}
