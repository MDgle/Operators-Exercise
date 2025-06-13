namespace OperatorExercise
{
    public class Program
    {

        static void Main(string[] args)
        {

            int x = 2;
            int y = 5;
            int addition = x + y;
            int subtraction = x - y;
            int multiplication = x * y;
            int a = 17;
            int b = 4;
            int quotient = a / b;
            int remainder = a % b;

            Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}");
        }
    }
}