using ImgToASCII;

if (args.Length < 1)
{
    Console.WriteLine("Please, drop image file on app executable or run \"ImgToASCII.exe\" with image path argument");
    Environment.Exit(0);
}

if (!File.Exists(args[0]))
{
    Console.WriteLine("Specified file doesn't exists");
    Environment.Exit(-1);
}

Bitmap bmp = new(16,16);

try
{
    bmp =  new Bitmap(args[0]);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
    Environment.Exit(-1);
}

Console.Title = $"{Path.GetFileName(args[0])} - {bmp.Width}x{bmp.Height}";

Console.Write("Show picture preview? [Y, N]: ");
ConsoleKeyInfo showPreview = Console.ReadKey(true);

if (showPreview.Key == ConsoleKey.Y)
{
    for (int y = 0; y < bmp.Height; y++)
    {
        for (int x = 0; x < bmp.Width; x++)
        {
            Console.BackgroundColor = RGBToANSI.Convert(bmp.GetPixel(x, y));
            Console.Write("  ");
            Console.ResetColor();
        }
        Console.SetCursorPosition(0, Console.GetCursorPosition().Top + 1);
    }
}

Console.Write("Save result as picture? [Y, N]: ");
ConsoleKeyInfo confirm = Console.ReadKey(true);

if (confirm.Key == ConsoleKey.Y)
{
    Bitmap bmpDeg = new(bmp.Width, bmp.Height);

    for (int y = 0; y < bmp.Height; y++)
    {
        for (int x = 0; x < bmp.Width; x++)
        {
            Color color = RGBToANSI.Deconvert(RGBToANSI.Convert(bmp.GetPixel(x,y)));

            bmpDeg.SetPixel(x, y, color);
        }
    }

    bmpDeg.Save(Path.GetFileNameWithoutExtension(args[0]) + "_deg.png");
    Console.WriteLine($"\nComplete! Picture is saved in application directory as \"{Path.GetFileNameWithoutExtension(args[0])}_deg.png\"");
}