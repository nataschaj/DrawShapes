using System;

namespace Sandbox
{
    class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            DrawingTool drawer = new DrawingTool();

            // Part 2a
            Console.WriteLine("Solution for 2a");
            for (int x = 0; x < 10; x++)
            {
                drawer.DrawOneStar();
            }
            Console.WriteLine();

            // Part 2b
            Console.WriteLine("Solution for 2b");
            for (int x = 0; x < 5; x++)
            {
                drawer.DrawOneStar();
                drawer.DrawOneSpace();
            }
            Console.WriteLine();

            // Part 2c
            Console.WriteLine("Solution for 2c");
            for (int y = 0; y < 10; y++)
            {
                for (int x = 0; x < 10; x++)
                {
                    drawer.DrawOneStar();
                }
                drawer.StartNewLine();
            }
            Console.WriteLine();

            // Part 2d
            Console.WriteLine("Solution for 2d");
            for (int y = 0; y < 10; y++)
            {
                for (int x = 0; x <= y; x++)
                {
                    drawer.DrawOneStar();
                }
                drawer.StartNewLine();
            }
            Console.WriteLine();

            // Part 2e
            Console.WriteLine("Solution for 2e");
            for (int y = 0; y < 10; y++)
            {
                for (int x = 0; x < 10; x++)
                {
                    if ((x == y) || (x + y == 9))
                    {
                        drawer.DrawOneStar();
                    }
                    else
                    {
                        drawer.DrawOneSpace();
                    }
                }
                drawer.StartNewLine();
            }
            Console.WriteLine();

            // The LAST line of code should be ABOVE this line
        }
    }
}
