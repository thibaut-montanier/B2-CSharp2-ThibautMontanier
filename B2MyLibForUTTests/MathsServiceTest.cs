
using B2MyLibForUT.Services;
using NUnit.Framework;
using System;

namespace B2MyLibForUTTests {
    public class MathServiceTests {


        private static MathsService _ms;

        [SetUp]
        public void Setup() {
            _ms = new MathsService();
        }

        [TestCase(2,2,0)]
        [TestCase(0,2,-2)]
        [TestCase(-1,-2,1)]
        [TestCase(-4,-2,-2)]
        public void AddTest(int expected, int num1, int num2) {
            int result = _ms.Add(num1, num2);
            Assert.AreEqual(expected, result, "Le résultat de l'addition n'est pas bon");
            
        }


        [TestCase(2, 4, 2)]
        [TestCase(-2, 4, -2)]
        [TestCase(0.3333333333333333333, 1, 3)]
        public void DiviseTest(decimal expected, decimal num1, decimal num2) {
            
            decimal result = _ms.Divise(num1, num2);
            Assert.AreEqual(expected, result, "La division n'est pas bonne");

        }

        [Test]
        public void DivisePar0() {

            //Assert.Throws<DivideByZeroException>(() => _ms.Divise(25, 0));
            decimal result=0;
            try {
                result = _ms.Divise(25, 0);
                Assert.Fail("il ne devrait pas y avoir de résultat pour la division par 0");
            } catch(Exception e) {

            }
            Console.WriteLine(result);
        }

        [Test]
        public void DiviseNbNonFinis() {

            //Assert.Throws<DivideByZeroException>(() => _ms.Divise(25, 0));
            MathsService.Add3Nombres(1, 2, 3);
            decimal result = _ms.Divise(1, 3);
            Assert.That(result, Is.EqualTo(0.33).Within(0.01));
        }


        [Test]
        public void AddTest() {
            
            _ms = null;

            

        }

        public int DemandeEntier() {
            return DemandeEntier("Saisie un nombre entier");
        }
        public int DemandeEntier(string message) {
            return 1;
        }

        public int DemandeEntier(string message, int valeurInterdite) {
            return DemandeEntier(message);
        }

        
    }
}