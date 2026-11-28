namespace GenericsHomeWork
{
    public static class ConsoleDisplayer
    {
        public static string Concat<A, B>(A a, B b, char symbol)
        {
            string result = a?.ToString() + " " + symbol + " " + b?.ToString();

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(result);
            Console.ResetColor();
            return result;
        }
    }
}
