using System;
using System.Windows.Forms;

namespace ArchiveApp
{
    internal static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                // якщо Ї аргументи, запускати консольну верс≥ю
                ConsoleArchiver.Run(args);
            }
            else
            {
                // ≤накше запускати граф≥чний ≥нтерфейс
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            }
        }
    }
}
