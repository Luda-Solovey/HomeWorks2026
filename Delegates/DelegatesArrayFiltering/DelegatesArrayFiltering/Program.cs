using System.Text;

namespace DelegatesArrayFiltering
{
    internal class Program
    {
        public static bool IsDevisibleBy5(int number)
        {
            bool result = number % 5 == 0;
            return result;
        }


        static void Main(string[] args)
        {
            //List<int> newArray = new();

            //int[] mass = [-9, -4, 0, 2, 3, 4, 6, 10];
            //foreach (var item in mass)
            //{
            //    if (item % 2 == 0)
            //    {
            //        newArray.Add(item);
            //    }
            //}

            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            int[] mass = [-9, -4, 0, 2, 3, 4, 6, 10, 22, 48];

            int[] newArray = ArrayExtensions.FilterArray(mass, x => x % 2 == 0);
            Console.WriteLine("Тільки парні числа");
            foreach (var item in newArray)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(new string('-', 50));


            int[] newArrayMiltiplayed = ArrayExtensions.FilterArray(mass, x => x > 10);
            Console.WriteLine("Числа, більші 10");
            foreach (var item in newArrayMiltiplayed)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(new string('-', 50));

            int[] increasedArray = ArrayExtensions.FilterArray(mass, x => { return (x * 2) < 20; } ); //лямбда-оператор (декілька лямбда-виразів в фігурних дужках {} + return)
            Console.WriteLine("Якась інша логіка");
            foreach (var item in increasedArray)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(new string('-', 50));

            int[] devisibleBy5 = ArrayExtensions.FilterArray(mass, IsDevisibleBy5);//можна передати метод
            Console.WriteLine("Числа, що діляться на 5 без залишку");
            foreach (var item in devisibleBy5)
            {
                Console.WriteLine(item);
            }
        }
    }
}
