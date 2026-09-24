    namespace la2026_09_24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string hw = "Hello world!";

            foreach (var c in hw)
            {
                Console.ForegroundColor = (ConsoleColor)Random.Shared.Next(1, 16);
                Console.WriteLine(c);
            }

            while (Console.ReadKey(true).Key != ConsoleKey.Escape);


        }
    }
}
