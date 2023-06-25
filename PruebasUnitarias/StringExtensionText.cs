using ClasesCarniceria;
using ClasesCarniceria.Excepctions;

namespace PruebasUnitarias

// Sirve para probar funciones, o sea que dentro tenemos que usar alguna.
{
    [TestClass]
    public class StringExtensionText
    {
        [TestMethod]
        public void ContarCantidadMinusculas_cuandoHayCincoMinisculas_retornaCinco()
        {
            int expected = 5;
            // Arrange
            string text = "Holass";
            // act
            int actual = ControlarString.ContarCantidadMinusculas(text);
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ContarCantidadMinusculas_cuandoHayCeroMinisculas_retornaCero()
        {
            int expected = 0;
            // Arrange
            string text = "HOLA";
            // act
            int actual = ControlarString.ContarCantidadMinusculas(text);
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ContarVocales_CuandoNoTieneVocales_DeberiaRetornarCero()
        {
            // Arrange
            int expected = 0;
            string text = "tyrypl kg";
            // Act
            int actual = text.ContarVocales();
            // Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void ContarVocales_CuandoTieneVocales_DeberiaRetornarTres()
        {
            // Arrange
            int expected = 3;
            string text = "LA COSA";
            // Act
            int actual = text.ContarVocales();
            // Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        [ExpectedException(typeof(TextoNuloException))]
        public void ContarVocales_CuandoElTextoEsNulo_DeberiaDevolverTextoNuloException()
        {
            string text = null;
            text.ContarVocales();
        }
        [TestMethod]
        public void ContarCaracteres_CuandoNoTieneCaracter_DeberiaRetornarCero()
        {
            // Arrange
            int expected = 0;
            string text = "fdfsgg";
            char caracter = ';';
            // Act
            int actual = text.ContarCaracter(caracter);
            // Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void ContarCaracteres_CuandoTieneDosCaracteres_DeberiaRetornarDos()
        {
            // Arrange
            int expected = 2;
            string text = "fd;fsg;g";
            char caracter = ';';
            // Act
            int actual = text.ContarCaracter(caracter);
            // Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        [ExpectedException(typeof(TextoNuloException))]
        public void ContarCaracteres_CuandoElTextoEsNulo_DeberiaLanzarBusinessException()
        {
            // Arrange
            int expected = 0;
            string text = null;
            char caracter = ';';
            // Act
            int actual = text.ContarCaracter(caracter);
            // Assert
            Assert.AreEqual(expected, actual);

        }
    }
}