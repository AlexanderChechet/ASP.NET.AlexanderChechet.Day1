namespace Task2
{
    public delegate int Condition(int[] array);

    public class Sorter
    {
        public static void Sort(int[][] array, Condition condition, bool ascending = false)
        {
            int n = array.Length;
            var subArray = new int[n];
            for (int i = 0; i < n; i++)
            {
                subArray[i] = condition(array[i]);
            }
            SortByArray(array, subArray, ascending);
        }

        private static void SortByArray(int[][] array, int[] subArray, bool ascending)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int key = subArray[i];
                int index = i;
                for (int j = i; j < array.Length; j++)
                {
                    if (((subArray[j].CompareTo(key)) < 0) == ascending)
                    {
                        key = subArray[j];
                        index = j;
                    }
                }
                Swap(ref array[i], ref array[index]);
                Swap(ref subArray[i], ref subArray[index]);
            }
        }

        private static void Swap(ref int a,ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        private static void Swap(ref int[] a, ref int[] b)
        {
            int[] temp = a;
            a = b;
            b = temp;
        }
    }
}
