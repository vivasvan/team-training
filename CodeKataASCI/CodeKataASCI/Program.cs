namespace CodeKataASCI
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            try
            {
                var number = Console.ReadLine();

                var numbers = (number ?? throw new InvalidOperationException()).Select(o => new Digit(int.Parse(o.ToString()))).ToList();

                WriteDigits(numbers);

                Console.ReadLine();
            }
            catch (Exception e)
            {
                // ignored
            }
        }

        private static void WriteDigits(IEnumerable<Digit> digits)
        {
            foreach (var digit in digits)
            {
                Console.Write(digit.FirstLine);
            }

            Console.Write("\r\n");

            foreach (var digit in digits)
            {
                Console.Write(digit.SecondLine);
            }

                Console.Write("\r\n");

            foreach (var digit in digits)
            {
                Console.Write(digit.ThirdLine);
            }

            Console.Write("\r\n");
        }
    }
}
