using System;
using System.Runtime.InteropServices;

class Program
{
    // Import MessageBox function from user32.dll
    [DllImport("user32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
    static extern int MessageBox(IntPtr hWnd, String text, String caption, int type);

    static void Main()
    {
        MessageBox(IntPtr.Zero, "Hello, World!", "My Message Box", 0);
        MessageBox(IntPtr.Zero, "\n Hello im Zakaria Elfakhar \n i have 22 Years", "Success", 1);
    }
}