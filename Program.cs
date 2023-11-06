namespace project
{
    internal class Program
    {
        static void Main(string[] args)
        {

            float result = 0;
            string oper;

            Console.Write("Enter the first value higher than the second value");
            Console.WriteLine("Enter the first value: ");
            float num1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            float num2 = float.Parse(Console.ReadLine());

            Console.WriteLine("To choose the operation press the following keys\n A-Addition \n S-Subraction \n M-Multiplication \n DQ-Division Quotient \n DR-Devision remainder");
            oper = Console.ReadLine().ToLower();

            switch (oper)
            {
                case "a":
                    {
                        result = num1 + num2;
                        break;
                    }
                case "s":
                    {
                        result = num1 - num2;
                        break;
                    }
                case "m":
                    {
                        result = num1 * num2;
                        break;
                    }
                case "dq":
                    {
                        result = num1 / num2;
                        break;
                    }
                case "dr":
                    {
                        result = num1 % num2;
                        break;
                    }
                default:
                    {
                        Console.WriteLine("****************************************************************");
                        Console.WriteLine("Enter the character listed above");
                        Console.WriteLine("****************************************************************");
                        break;
                    }
            }
            Console.WriteLine("The answer is: "+result );

            Console.ReadLine();
        }
    }
}