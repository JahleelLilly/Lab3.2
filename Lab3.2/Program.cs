namespace Lab3._2
{
    class Program
    {

        //Sum of all digits in a String//
        static void Main()
        {
            Console.WriteLine(SumDigitsInString("1q2w3e")); //6
            Console.WriteLine(SumDigitsInString("L0r3m.1p5um")); //9
            Console.WriteLine(SumDigitsInString("***")); //0
        }
        static int SumDigitsInString(string str)
        {
            int sum = 0;

            foreach (char c in str)
            {
                if (char.IsDigit(c))
                {
                    sum += c - '0';
                }

            }
            return sum;
        }
    }
}
