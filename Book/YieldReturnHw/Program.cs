namespace YieldReturnHw
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var array1 = new string[] { "apple", "banana", "cherry", "date", "fig", "grape", "kiwi", "lemon", "mango", "nectarine", "orange", "mango" };
            var array2 = new string[] { "apple", "cherry", "grape", "kiwi", "mango" };

            //var equalWords = array1.GetEqualWords(array2);//1й спосіб виклику 
            var equalWords = EnumerableExtensions.GetEqualWords(array1, array2);//2й спосіб виклику

        Console.WriteLine("Equal words:");
            foreach (var word in equalWords)
            {
                Console.WriteLine(word);
            }
        }
    }
}
