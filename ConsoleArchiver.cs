using System;
using System.IO;

namespace ArchiveApp
{
    public static class ConsoleArchiver
    {
        public static void Run(string[] args)
        {
            if (args.Length < 3)
            {
                Console.WriteLine("Usage: <mode> <source> <destination> [password]");
                Console.WriteLine("Modes: -c (compress), -d (decompress)");
                return;
            }

            string mode = args[0];
            string source = args[1];
            string destination = args[2];
            string password = args.Length > 3 ? args[3] : null;

            try
            {
                if (mode == "-c")
                {
                    ArchiveHelper.Compress(source, destination, password);
                    Console.WriteLine("Compression completed.");
                }
                else if (mode == "-d")
                {
                    ArchiveHelper.Decompress(source, destination, password);
                    Console.WriteLine("Decompression completed.");
                }
                else
                {
                    Console.WriteLine("Invalid mode. Use -c for compress or -d for decompress.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
