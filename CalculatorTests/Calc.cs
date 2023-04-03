namespace CalculatorTests
{
    internal class Calc
    {
        public static float SommaNumeri(float num1, float num2)
        {
            return num1 + num2;
        }

        public static float DifferenzaNumeri(float num1, float num2)
        {
            return num1 - num2;
        }

        public static float DivisioneNumeri(float num1, float num2)
        {
            //if (num1 == 0 || num2 == 0)
            //{
            //    throw new ArgumentException("non possono essere entrambi 0");
            //}
            return num1 / num2;
        }

        public static float MoltiplicazioneNumeri(float num1, float num2)
        {
            return num1 * num2;
        }

    }
}

