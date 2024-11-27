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
                // ���� � ���������, ��������� ��������� �����
                ConsoleArchiver.Run(args);
            }
            else
            {
                // ������ ��������� ��������� ���������
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            }
        }
    }
}
