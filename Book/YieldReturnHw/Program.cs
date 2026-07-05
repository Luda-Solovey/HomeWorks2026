namespace YieldReturnHw
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var array1 = new string[] { "apple", "banana", "cherry", "date", "fig", "grape", "kiwi", "lemon", "mango", "nectarine", "orange", "mango" };
            var array2 = new string[] { "apple", "cherry", "grape", "kiwi", "mango" };

            var equalWords = array1.GetEqualWords(array2);

            Console.WriteLine("Equal words:");
            foreach (var word in equalWords)
            {
                Console.WriteLine(word);
            }
        }
    }
}
