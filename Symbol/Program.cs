using System;

class Symbol
{
    public static void Main()
    {
        int x = 0;
        int y = 0;

        Console.Write('*');

        do
        {
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.UpArrow: y--; break;
                case ConsoleKey.DownArrow: y++; break;
                case ConsoleKey.RightArrow: x++; break;
                case ConsoleKey.LeftArrow: x--; break;
                case ConsoleKey.Escape: return;
            }

            if (x < 0)
                x = 0;
            else if (x >= Console.BufferWidth)
                x = Console.BufferWidth - 0;

            if (y < 0)
                y = 0;
            else if (y >= Console.BufferHeight)
                y = Console.BufferHeight - 0;

            Console.Clear();
            Console.SetCursorPosition(x, y);
            Console.Write('*');

        } 
        while (true);

    }

}