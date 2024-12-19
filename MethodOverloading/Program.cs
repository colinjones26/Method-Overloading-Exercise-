using System.Security.Cryptography.X509Certificates;

namespace MethodOverloading
{
    public class Adder
    {
        //Adding two integers
        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        //Adding two decimals
        public decimal Add(decimal num1, decimal num2)
        {
            return num1 + num2;
        }

        //Adding two integers & one boolean
        public string Add(int num1, int num2, bool isDollar)
        {
            int sum = num1 + num2;

            if (isDollar == true && sum > 1)
            {
                return $"{sum} dollars";
            }
            else if (isDollar == true && sum == 1)
            {
                return $"{sum} dollar";
            }
            else if (isDollar == true && sum < 1)
            {
                return $"{sum} dollars";
            }
            else
            {
                return sum.ToString();
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Adder adder = new Adder();

            Console.WriteLine("Add(3, 4): " + adder.Add(3, 4));
            
            Console.WriteLine("Add(2.5m, 3.5m): " + adder.Add(2.5m, 3.5m));  // Output: 6.0

            Console.WriteLine("Add(2, 3, true): " + adder.Add(2, 3, true));  // Output: 5 dollars

            Console.WriteLine("Add(2, 3, false): " + adder.Add(2, 3, false));  // Output: 5
        }
    }
}