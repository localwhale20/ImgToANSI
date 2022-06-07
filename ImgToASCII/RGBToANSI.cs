namespace ImgToASCII;
public static class RGBToANSI
{
    // [Alpha] RGB values based on https://devblogs.microsoft.com/commandline/updating-the-windows-console-colors/
    // [Alpha] Or easily, combined Legacy and New console color scheme
    
    // Color converter have colors, that I'm created myself
    public static ConsoleColor Convert(Color color)
    {
        // to prevent blackness
        if (color.A == 0)
            return ConsoleColor.White;

        if (color.R <= 30 && color.G <= 30 && color.B <= 30)
            return ConsoleColor.Black;
        else if (color.R <= 50 && color.G <= 50 && color.B <= 150)
            return ConsoleColor.DarkBlue;
        else if (color.R <= 50 && color.G <= 150 && color.B <= 50)
            return ConsoleColor.DarkGreen;
        else if (color.R <= 55 && color.G <= 150 && color.B <= 150)
            return ConsoleColor.DarkCyan;
        else if (color.R <= 185 && color.G <= 65 && color.B <= 65)
            return ConsoleColor.DarkRed;
        else if (color.R <= 150 && color.G <= 65 && color.B <= 150)
            return ConsoleColor.DarkMagenta;
        else if (color.R <= 150 && color.G <= 150 && color.B <= 65)
            return ConsoleColor.DarkYellow;
        else if ((color.R >= 100 && color.R <= 150) && (color.G >= 100 && color.G <= 150) && (color.B >= 100 && color.B <= 150))
            return ConsoleColor.Gray;
        else if ((color.R >= 30 && color.R <= 100) && (color.G >= 30 && color.G <= 100) && (color.B >= 30 && color.B <= 100))
            return ConsoleColor.DarkGray;
        else if (color.R < 50 && color.G < 50 && color.B > 150)
            return ConsoleColor.Blue;
        else if (color.R < 50 && color.G > 150 && color.B < 50)
            return ConsoleColor.Green;
        else if (color.R < 50 && color.G > 150 && color.B > 150)
            return ConsoleColor.Cyan;
        else if (color.R > 150 && color.G < 50 && color.B < 50)
            return ConsoleColor.Red;
        else if (color.R > 150 && color.G < 50 && color.B > 150)
            return ConsoleColor.Magenta;
        else if (color.R > 150 && color.G > 150 && color.B < 50)
            return ConsoleColor.Yellow;
        else if (color.R > 150 && color.G > 150 && color.B > 150)
            return ConsoleColor.White;
        else
            return ConsoleColor.DarkGray;
    }
    public static Color Deconvert(ConsoleColor color)
    {
        switch (color)
        {
            case ConsoleColor.Black:
                return Color.FromArgb(12, 12, 12);
            case ConsoleColor.DarkBlue:
                return Color.FromArgb(0, 55, 218);
            case ConsoleColor.DarkGreen:
                return Color.FromArgb(19, 161, 14);
            case ConsoleColor.DarkCyan:
                return Color.FromArgb(58, 150, 221);
            case ConsoleColor.DarkRed:
                return Color.FromArgb(197, 15, 31);
            case ConsoleColor.DarkMagenta:
                return Color.FromArgb(136, 23, 152);
            case ConsoleColor.DarkYellow:
                return Color.FromArgb(193, 156, 0);
            case ConsoleColor.DarkGray:
                return Color.FromArgb(204, 204, 204);
            case ConsoleColor.Gray:
                return Color.FromArgb(118, 118, 118);
            case ConsoleColor.Blue:
                return Color.FromArgb(59, 120, 255);
            case ConsoleColor.Green:
                return Color.FromArgb(22, 198, 12);
            case ConsoleColor.Red:
                return Color.FromArgb(231, 72, 86);
            case ConsoleColor.Cyan:
                return Color.FromArgb(97, 214, 214);
            case ConsoleColor.Magenta:
                return Color.FromArgb(180, 0, 158);
            case ConsoleColor.Yellow:
                return Color.FromArgb(249, 241, 165);
            case ConsoleColor.White:
                return Color.FromArgb(242, 242, 242);
            default:
                return Color.FromArgb(118, 118, 118);
        }
    }
}
