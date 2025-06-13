namespace OperatorExercise
{
    public class Program
    {
        public static void CircleAreaCalculation()
        {
            Console.WriteLine("Area of a circle = PI multiplied by the square of the radius.");
            Console.WriteLine("Enter Radius");
            var Radius = double.Parse(Console.ReadLine());
            Console.WriteLine($"Circle Area = {Math.PI * (Radius * Radius)}");
        }

        
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
            CircleAreaCalculation();
            Console.WriteLine("Calculation complete, Have a nice day!");
        }
    }
}
