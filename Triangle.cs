using System;

namespace Week2ChallengeLabs
{
    public static class Triangle
    {
        

        public static void DisplayTriangle(int number, int width)
        {
            for (int i = 0; i < number; i++)
            {
                for (int j = width; j > 0; j--)
                {
                    Console.Write(number);
                    
                }
                Console.WriteLine();
                width--;
            }
        }
    }
}
