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

        public int TotalMarks => Physics + Chemistry + ComputerApplication;
        public double Percentage => (double)TotalMarks / 3;

        public string Division => Percentage switch
        {
            >= 70 => "First",
            >= 50 and < 70 => "Second",
            >= 40 and < 49 => "Third",
            _ => "Failed"
        };

        //public int CalculateMarks()
        //{
        //    return Physics + Chemistry + ComputerApplication;
        //}

        //public double CalculatePercentage(int totalMarks)
        //{
        //    return (double)totalMarks / 3;
        //}

        //public string GetDivision(double percentage)
        //{
        //    return percentage switch
        //    {
        //        >= 70 => "First",
        //        >= 50 and < 70 => "Second",
        //        >= 40 and < 49 => "Third",
        //        _ => "Failed"
        //    };
        //}

        public void DisplayStudent()
        {
            Console.WriteLine($"Roll No: {RollNumber}");
            Console.WriteLine($"Marks in Physics: {Physics}");
            Console.WriteLine($"Marks in Chemistry: {Chemistry}");
            Console.WriteLine($"Marks in Computer Application: {ComputerApplication}");
            Console.WriteLine($"Total Marks = {TotalMarks}");
            Console.WriteLine($"Percentage = {Percentage:F2}");
            Console.WriteLine($"Division = {Division}");
        }
    }
}
