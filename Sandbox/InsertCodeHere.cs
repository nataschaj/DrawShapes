using System;

namespace Sandbox
{
    class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            DrawingTool drawer = new DrawingTool();


            // YOUR JOB: Add code to draw shapes
            Console.WriteLine("2. Shape A");
            for (int i = 0; i < 10; i++)
            {
                drawer.DrawOneStar();
            }
            Console.WriteLine();

            Console.WriteLine("2. Shape B");
            for (int i = 0; i < 5; i++)
            {
                drawer.DrawOneStar();
                drawer.DrawOneSpace();
            }
            Console.WriteLine();

            Console.WriteLine("2. Shape C");
            for (int i = 0; i < 10; i++)
            {
                for (int y = 0; y < 10; y++)
                {
                    drawer.DrawOneStar();
                }
                drawer.StartNewLine();
            }
            Console.WriteLine();


            Console.WriteLine("2. Shape D");
            for (int i = 0; i < length; i++)
            {

            }
            Console.WriteLine();

            // The LAST line of code should be ABOVE this line
        }
    }
}
