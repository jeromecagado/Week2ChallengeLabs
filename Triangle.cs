using System;

namespace Week2ChallengeLabs
{
    public static class Triangle
    {
        

        public static void DisplayTriangle(char character, int width)
        {
            int length = width;
            for (int i = 0; i < length; i++)
            {
                for (int j = width; j > 0; j--)
                {
                    Console.Write(character);
                }
                Console.WriteLine();
                width--;
            }
        }
    }
}
