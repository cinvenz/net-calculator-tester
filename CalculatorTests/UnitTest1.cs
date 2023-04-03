namespace CalculatorTests
{
    [TestFixture]
    public class CalculatorTests
    {

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(3, 3, 6)]
        [TestCase(-2, 3, 1)]
        [TestCase(0, 0, 0)]
        public void TestSommaNumeri(float num1, float num2, float TestResult)
        {
            float somma = Calc.SommaNumeri(num1, num2);
            Assert.That(TestResult == somma);
        }

        [Test]
        [TestCase(5, 3, 2)]
        [TestCase(-5, 3, -8)]
        [TestCase(0, 0, 0)]
        public void TestDifferenzaNumeri(float num1, float num2, float TestResult)
        {
            float differenza = Calc.DifferenzaNumeri(num1, num2);
            Assert.That(TestResult == differenza);
        }

        [Test]
        [TestCase(6, 3, 2)]
        [TestCase(-6, 3, -2)]
        public void TestDivisioneNumeri(float num1, float num2, float TestResult)
        {
            float divisione = Calc.DivisioneNumeri(num1, num2);
            Assert.That(TestResult == divisione);
        }

        [Test]
        [TestCase(2, 3, 6)]
        [TestCase(-2, 3, -6)]
        [TestCase(0, 0, 0)]
        public void TestMoltiplicazioneNumeri(float num1, float num2, float TestResult)
        {
            float moltiplicazione = Calc.MoltiplicazioneNumeri(num1, num2);
            Assert.That(TestResult == moltiplicazione);
        }
    }
}
