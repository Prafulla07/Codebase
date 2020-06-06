namespace DataStructure.Console
{
    public static class Searching
    {
        public static int BinarySearhc(int[] array, int target)
        {
            var left = 0;
            var right = array.Length;

            while (left <= right)
            {
                var middle = (left + right) / 2;

                if (array[middle] == target)
                    return middle;

                if (target < array[middle])
                    right = middle - 1;

                else
                    left = middle + 1;
            }


            return -1;

        }

    }


}
