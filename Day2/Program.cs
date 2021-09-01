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
                int validOldPasswordCount = 0;
                int validNewPasswordCount = 0;
                int passwordCounts = 0;

                foreach (var row in File.ReadLines("source.txt"))
                {
                    if (new PolicyChecker(row).CheckOldPolicy())
                    {
                        validOldPasswordCount++;
                    }

                    if (new PolicyChecker(row).CheckNewPolicy())
                    {
                        validNewPasswordCount++;
                    }

                    passwordCounts++;
                }

                return @$"Passwords: {passwordCounts}
Valid old policy passwords: {validOldPasswordCount}
Valid new policy passwords: {validNewPasswordCount}";
            }
            catch(Exception ex)
            {
                return $"Error: {ex.Message}";
            }
        }
    }
}
