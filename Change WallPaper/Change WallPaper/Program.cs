using System;
using System.Runtime.InteropServices;

class Program
{
    // Import the SystemParametersInfo function from user32.dll
    [DllImport("user32.dll", CharSet = CharSet.Auto)]
    public static extern int SystemParametersInfo(
        uint action, uint uParam, string vParam, uint winIni);

    // Constants for the function
    public static readonly uint SPI_SETDESKWALLPAPER = 0x14;
    public static readonly uint SPIF_UPDATEINIFILE = 0x01;
    public static readonly uint SPIF_SENDCHANGE = 0x02;

    //   Example 2: Get Screen Resolution

    [DllImport("user32.dll")]
    static extern int GetSystemMetrics(int Index);

    static void Main()
    {
        // The path to the wallpaper image
        string wallpaperPath = @"C:\Users\lenovo\Desktop\walpaper\littel panda.jpg";

        // Set the wallpaper
        //  SetWallpaper(wallpaperPath);

        int ScreenWidth = GetSystemMetrics(0);
        int ScreenHeight = GetSystemMetrics(1);

        Console.WriteLine($" Screen Width : {ScreenWidth} , Screen Hight : {ScreenHeight}");


        Console.ReadKey();

    }

    public static void SetWallpaper(string path)
    {
        SystemParametersInfo(SPI_SETDESKWALLPAPER, 0, path, SPIF_UPDATEINIFILE | SPIF_SENDCHANGE);
        Console.WriteLine("Wallpaper changed successfully!");
    }
}
