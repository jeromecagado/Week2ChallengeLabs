using System;



namespace Week2ChallengeLabs
{
    public class Student
    {
        public int RollNumber { get; set; }
        public string Name { get; set; }
        public int Physics { get; set; }
        public int Chemistry { get; set; }
        public int ComputerApplication { get; set; }

        public int CalculateMarks()
        {
            return Physics + Chemistry + ComputerApplication;
        }

        public double CalculatePercentage(int totalMarks)
        {
            return (double)totalMarks / 3;
        }

        public string GetDivision(double percentage)
        {
            string division = "";
            switch (percentage)
            {
                case >= 60:
                    division = "First";
                    break;
                case >= 50 and < 60:
                    division = "Second";
                    break;
                case >= 40 and < 50:
                    division = "Third";
                    break;
                default:
                    division = "Failed";
                    break;
            }
            return division;
        }

        public void DisplayStudent(int totalMarks, double percentage, string division)
        {
            Console.WriteLine($"Roll No: {RollNumber}");
            Console.WriteLine($"Marks in Physics: {Physics}");
            Console.WriteLine($"Marks in Chemistry: {Chemistry}");
            Console.WriteLine($"Marks in Computer Application: {ComputerApplication}");
            Console.WriteLine($"Total Marks = {totalMarks}");
            Console.WriteLine($"Percentage = {percentage:F2}");
            Console.WriteLine($"Division = {division}");
        }
    }
}
