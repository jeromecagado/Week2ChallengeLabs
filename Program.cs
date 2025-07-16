namespace Week2ChallengeLabs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Assignment 1:
            Console.WriteLine("Hello, welcome to the reading temperature application.\n");

            double[] temperatures = [67, 100, 20, 0, 45, 10, 70];
            Temperature temperature = new Temperature();

            foreach (double temp in temperatures)
            {
                temperature.DisplayTemperature(temp);
            }
            Console.WriteLine("Press Enter to continue\n");
            Console.ReadLine();
            Console.WriteLine();


            // Assignment 2:
            Password password = new Password();
            password.UserId = "jcagado";
            password.UserPassword = "LiverpoolFan";
            password.EnterLogin();

            // Assignment 3:
            PromptTriangle();

            // Assigment 4:
            Student student = new Student();
            student.RollNumber = 7;
            student.Name = "Jerome";
            student.Physics = 98;
            student.Chemistry = 92;
            student.ComputerApplication = 100;
            int totalMarks = student.CalculateMarks();
            double percentage = student.CalculatePercentage(totalMarks);
            string division = student.GetDivision(percentage);
            student.DisplayStudent(totalMarks, percentage, division);


        }

        public static void PromptTriangle()
        {
          
            while (true)
            {
                Console.WriteLine("\nEnter a number: ");
                if(!int.TryParse(Console.ReadLine(), out int number))
                {
                    Console.WriteLine("Incorrect input. Please enter a postive integer.");
                    continue;
                }
                Console.WriteLine("Enter a width:");
                if(!int.TryParse(Console.ReadLine(), out int width))
                {
                    Console.WriteLine("Incorrect input. Please enter a postive integer.");
                    continue;
                }

                Triangle.DisplayTriangle(number, width);
                break;
            }
        }

        public class Temperature
        {
            public double Value { get; set; }

            public void DisplayTemperature(double value)
            {
                switch (value)
                {
                    case < 10:
                        Console.WriteLine($"{value} degrees Fahrenheit is Freezing weather!");
                        break;
                    case >= 11 and <= 20:
                        Console.WriteLine($"{value} degrees Fahrenheit is Very Cold weather!");
                        break;
                    case >= 21 and <= 35:
                        Console.WriteLine($"{value} degrees Fahrenheit is Cold weather!");
                        break;
                    case >= 36 and <= 50:
                        Console.WriteLine($"{value} degrees Fahrenheit is Normal weather!");
                        break;
                    case >= 51 and <= 65:
                        Console.WriteLine($"{value} degrees Fahrenheit is Hot weather!");
                        break;
                    case >= 66 and <= 80:
                        Console.WriteLine($"{value} degrees Fahrenheit is Very Hot weather!");
                        break;
                }
            }

        }
    }
}
