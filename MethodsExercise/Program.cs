using System.Data;

namespace MethodsExercise
{
    public class Program
    {
        //Story Method
        public static string GetQuestionAnswer(string question)
        {
            Console.WriteLine(question);
            string answer = Console.ReadLine();
            return answer;
        }
        //Math Methods
        public static int Sum(int num1, int num2)
        {
            int solution = num1 + num2;
            return solution;
        }
        public static int Subtract(int num1, int num2)
        {
            int solution = num1 - num2;
            return solution;
        }
        public static int Multiply(int num1, int num2)
        {
            int solution = num1 * num2;
            return solution;
        }
        public static double Divide(int num1, int num2)
        {
            double dNum1 = Convert.ToDouble(num1);
            double dNum2 = Convert.ToDouble(num2);
            double solution = dNum1 / dNum2;
            return solution;
        }


        static void Main(string[] args)
        {
            //Story main code
            Console.WriteLine("Start Code: Let's make a story together!");
            string animal1 = GetQuestionAnswer("first, give me an animal.");
            string animal2 = GetQuestionAnswer("Now, give me another animal.");
            string time = GetQuestionAnswer("Give me a time, like minute, year, Monday, etc. Just one though!");
            string game = GetQuestionAnswer("Name a game, like basketball or checkers.");
            string num1 = GetQuestionAnswer("Next, a number, like 1, 26, etc.");
            string num2 = GetQuestionAnswer("Now, one more number. Last prompt!");
            Console.WriteLine("Okay, now for the story! \n");

            Console.WriteLine($"The {animal1} and the {animal2} like to get\n" +
                $"together every {time} to play {game}.\n" +
                $"The score is {animal1} {num1} and {animal2} {num2}!\n");

            //Show math methods work
            Console.WriteLine("Now to show off some custom math methods.");
            Console.WriteLine("Give me two integers please. (one at a time)");
            int num3 = Convert.ToInt32(Console.ReadLine());
            int num4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Add second number to first number.");
            Console.WriteLine(Sum(num3, num4));
            Console.WriteLine("Subtract second number from first number.");
            Console.WriteLine(Subtract(num3, num4));
            Console.WriteLine("Multiply first number by second number.");
            Console.WriteLine(Multiply(num3, num4));
            Console.WriteLine("Divide first number by second number.");
            Console.WriteLine(Divide(num3, num4));
        }
    }
}
