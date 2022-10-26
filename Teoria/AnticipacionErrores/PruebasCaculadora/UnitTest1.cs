using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnticipacionErrores;
using System;

namespace PruebasCaculadora
{
    [TestClass]
    public class UnitTest1
    {
        Calculadora miCalculadora = new Calculadora();
        
        [TestMethod]
        public void CasoPruebaSuma1()
        {
            int sumando1 = 2;
            int sumando2 = 3;
            int total = miCalculadora.suma(sumando1, sumando2);
            Assert.AreEqual(5, total);
        }

        [TestMethod]
        public void CasoPruebaSuma2()
        {
            int sumando1 = 0;
            int sumando2 = 2;
            int total = miCalculadora.suma(sumando1, sumando2);
            Assert.AreEqual(2, total);
        }


        [TestMethod]
        public void RestaPrueba1()
        {
            int minuendo = 2;
            int sustraendo = 1;
            int diferencia = miCalculadora.resta(minuendo, sustraendo);
            Assert.AreEqual(1, diferencia);
        }

        [TestMethod]
        public void RestaPrueba2()
        {
            int minuendo = 3;
            int sustraendo = 5;
            int diferencia = miCalculadora.resta(minuendo, sustraendo);
            Assert.AreEqual(-2, diferencia);
        }

        [TestMethod]
        public void RestaPrueba3()
        {
            int minuendo = 3;
            int sustraendo = 0;
            int diferencia = miCalculadora.resta(minuendo, sustraendo);
            Assert.AreEqual(3, diferencia);
        }

        [TestMethod]
        public void RestaPrueba4()
        {
            int minuendo = -3;
            int sustraendo = 2;
            int diferencia = miCalculadora.resta(minuendo, sustraendo);
            Assert.AreEqual(-5, diferencia);
        }

        [TestMethod]
        public void RestaPrueba5()
        {
            int minuendo = 3;
            int sustraendo = -4;
            int diferencia = miCalculadora.resta(minuendo, sustraendo);
            Assert.AreEqual(7, diferencia);
        }

        [TestMethod]
        public void MultiplicacionPrueba1()
        {
            int factor1 = 3;
            int factor2 = 2;
            int producto = miCalculadora.multiplicacion(factor1, factor2);
            Assert.AreEqual(6, producto);
        }

        [TestMethod]
        public void MultiplicacionPrueba2()
        {
            int factor1 = 2;
            int factor2 = 3;
            int producto = miCalculadora.multiplicacion(factor1, factor2);
            Assert.AreEqual(6, producto);
        }

        [TestMethod]
        public void MultiplicacionPrueba3()
        {
            int factor1 = -3;
            int factor2 = 2;
            int producto = miCalculadora.multiplicacion(factor1, factor2);
            Assert.AreEqual(-6, producto);
        }

        [TestMethod]
        public void MultiplicacionPrueba4()
        {
            int factor1 = 3;
            int factor2 = -2;
            int producto = miCalculadora.multiplicacion(factor1, factor2);
            Assert.AreEqual(-6, producto);
        }
    }
}
