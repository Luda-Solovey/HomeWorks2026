using System;
using System.Collections.Generic;
using System.Text;

namespace YieldReturnHw
{
    public static class MyClass
    {
        public static IEnumerable<string> GetEqualWords(this IEnumerable<string> source1, IEnumerable<string> source2)
        {
            if (source1 == null || source2 == null)
            {
                yield break; // якщо будь-який з джерел є null, припиняємо генерацію і повертаємо порожню колекцію
            }
            int count = 0;

            foreach (var word in source1) //якщо треба виключити повторювальні слова, тоді на source1 треба викликати метод Distinct: source1.Distinct()
            {
                if (source2.Contains(word))
                {
                    yield return word;

                    count++;

                    if (count >= 10)
                    {
                        yield break; // якщо знайдено 10 слів, прериваємо генерацію перелічуваного і виходимо з методу
                    }
                }

            }
        }
    }
}
