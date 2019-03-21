using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ordenamiento.Pruebas {
    [TestClass]
    public class PruebasOrdenamiento {
        private int[] salidaEsperada = new int[]{1,2,3,4,5};
        private int[] salidaEsperada2 = new int[]{1,1,1,1,1};
        private int[] salidaEsperada3 = new int[]{1,2,3,4,4};

        private Ordenamiento.Burbuja ordenar = new Ordenamiento.Burbuja();

        [TestMethod]
        public void TestInvertido() {
            int[] entrada = new int[]{5,4,3,2,1};
            ordenar.Ordenar(entrada);
            CollectionAssert.AreEqual(salidaEsperada, entrada);
        }

        [TestMethod]
        public void TestOrdenado() {
            int[] entrada = new int[]{1,2,3,4,5};
            ordenar.Ordenar(entrada);
            CollectionAssert.AreEqual(salidaEsperada, entrada);
        }

        [TestMethod]
        public void TestVolteado() {
            int[] entrada = new int[]{1,3,2,4,5};
            ordenar.Ordenar(entrada);
            CollectionAssert.AreEqual(salidaEsperada, entrada);
        }

        [TestMethod]
        public void TestFinalInicio() {
            int[] entrada = new int[]{5,1,2,3,4};
            ordenar.Ordenar(entrada);
            CollectionAssert.AreEqual(salidaEsperada, entrada);
        }

        [TestMethod]
        public void TestInicioFinal() {
            int[] entrada = new int[]{2,3,4,5,1};
            ordenar.Ordenar(entrada);
            CollectionAssert.AreEqual(salidaEsperada, entrada);
        }

        [TestMethod]
        public void TestIguales() {
            int[] entrada = new int[]{1,1,1,1,1};
            ordenar.Ordenar(entrada);
            CollectionAssert.AreEqual(salidaEsperada2, entrada);
        }

        [TestMethod]
        public void TestRepetido() {
            int[] entrada = new int[]{1,2,3,4,4};
            ordenar.Ordenar(entrada);
            CollectionAssert.AreEqual(salidaEsperada3, entrada);
        }
    }
}
