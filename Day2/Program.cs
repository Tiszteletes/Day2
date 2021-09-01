using System;
using System.IO;

namespace Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckDay2());
        }

        private static string CheckDay2()
        {
            try
            {
                int validPasswordCount = 0;
                int passwordCounts = 0;

                foreach (var row in File.ReadLines("source.txt"))
                {
                    if (new PolicyChecker(row).Check())
                    {
                        validPasswordCount++;
                    }
                    passwordCounts++;
                }

                return $"Passords: {passwordCounts} Valid passwords: {validPasswordCount}";
            }
            catch(Exception ex)
            {
                return $"Error: {ex.Message}";
            }
        }
    }
}
