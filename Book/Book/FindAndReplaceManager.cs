using System;
using System.Collections.Generic;
using System.Text;

namespace Book
{
    public class FindAndReplaceManager
    {
        private static int currentIndex = -1; // запам’ятовуємо, де зупинилися

        public static void FindNext(string[] book, string str)
        {
            for (int i = currentIndex + 1; i < book.Length; i++)
            {
                if (book[i].Contains(str))
                {
                    Console.WriteLine($"Found on line {i}: {book[i]}");
                    currentIndex = i; // оновлюємо позицію
                    return;
                }
            }
            Console.WriteLine("No more matches found.");
        }
    }
}
