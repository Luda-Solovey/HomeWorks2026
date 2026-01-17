using System.Text;

namespace ChessHW
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            string[,] checks = new string[8, 8];

            // Initialize board
            // 8-а горизонталь (чорні важкі фігури)
            checks[0, 0] = "Тура";
            checks[0, 1] = "Кінь";
            checks[0, 2] = "Слон";
            checks[0, 3] = "Ферзь";
            checks[0, 4] = "Король";
            checks[0, 5] = "Слон";
            checks[0, 6] = "Кінь";
            checks[0, 7] = "Тура";

            // 7-а горизонталь (чорні пішаки)
            for (int i = 0; i < 8; i++)
                checks[1, i] = "Пішак";

            // 6-а, 5-а, 4-а, 3-а горизонталі (порожні клітинки)
            for (int i = 2; i < 6; i++) //i - номер горизонталі (номер масиву; рядка)
            {
                for (int j = 0; j < 8; j++) //j - номер вертикалі (номер елемента масиву; стовпчика)
                {
                    checks[i, j] = "_";
                }
            }

            // 2-а горизонталь (білі пішаки)
            for (int i = 0; i < 8; i++)
                checks[6, i] = "Пішак";

            // 1-а горизонталь (білі важкі фігури)
            checks[7, 0] = "Тура";
            checks[7, 1] = "Кінь";
            checks[7, 2] = "Слон";
            checks[7, 3] = "Ферзь";
            checks[7, 4] = "Король";
            checks[7, 5] = "Слон";
            checks[7, 6] = "Кінь";
            checks[7, 7] = "Тура";


            // Вisplay board
            for (int i = 0; i < 8; i++)
            {
                Console.Write($"{8-i} "); // нумерація ряду ліворуч (8..1)
                for (int j = 0; j < 8; j++)
                {
                    Console.Write(checks[i, j]);
                    Console.Write("|");
                }
                Console.WriteLine(" ");
            }
            Console.WriteLine("  a b c d e f g h");// нумерація стовпчиків внизу (a..h)
        }
    }
}
