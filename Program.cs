using Raylib_cs;

namespace Model;

class Program
{
    public static void Main()
    {
        Raylib.InitWindow(800, 800, "Hello World");
        var board = new Board();
        var piece = Piece.FromCharacter('k');
        Console.WriteLine(piece);
        while (!Raylib.WindowShouldClose())
        {
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.White);

            Raylib.DrawText("Hello, world!", 12, 12, 20, Color.Black);

            Raylib.EndDrawing();
        }

        Raylib.CloseWindow();
    }
}