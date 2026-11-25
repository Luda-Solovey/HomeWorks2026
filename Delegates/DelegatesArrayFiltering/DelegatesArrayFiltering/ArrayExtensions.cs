namespace DelegatesArrayFiltering
{
    public static class ArrayExtensions
    {
        public static int[] FilterArray(int[] array, Predicate<int> sortingMethod)
        {
            List<int> newArray = new List<int>();

            foreach (var item in array)
            {
                if (sortingMethod.Invoke(item))
                {
                    newArray.Add(item);
                }

            }
            return newArray.ToArray();
        }
    }
}
