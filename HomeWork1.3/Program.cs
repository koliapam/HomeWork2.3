using System;

namespace DecimalNumberApp
{
    public struct DecimalNumber
    {

        private int value;


        public DecimalNumber(int value)
        {
            this.value = value;
        }


        public string ToBinary()
        {
            return Convert.ToString(value, 2);
        }


        public string ToOctal()
        {
            return Convert.ToString(value, 8);
        }


        public string ToHexadecimal()
        {
            return Convert.ToString(value, 16).ToUpper();
        }

        public void Display()
        {
            Console.WriteLine($"Десяткове число: {value}");
        }


        public int GetValue()
        {
            return value;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = System.Text.Encoding.UTF8;


            DecimalNumber number = new DecimalNumber(255);


            number.Display();


            Console.WriteLine($"Двійкова система: {number.ToBinary()}");
            Console.WriteLine($"Вісімкова система: {number.ToOctal()}");
            Console.WriteLine($"Шістнадцяткова система: {number.ToHexadecimal()}");
        }
    }
}
