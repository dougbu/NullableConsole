using System;

namespace NullableConsole
{
    class Program
    {
#nullable enable
        static void Main(string[] args)
        {
            string? one = Environment.GetEnvironmentVariable("one");
            string? two = Environment.GetEnvironmentVariable("two");
            if (one == null && two == null)
            {
                Console.WriteLine("both null");
            }
            else if (one != null && two != null)
            {
                Console.WriteLine("both non-null");
            }
            else if (one != null)
            {
                Console.WriteLine("one is non-null");
            }
            else
            {
                Console.WriteLine(two.Length);
            }
        }
#nullable disable
    }
}
