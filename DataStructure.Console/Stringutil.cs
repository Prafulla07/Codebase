using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructure.Console
{
    public static class Stringutil
    {
        public static int CountVowels(string input)
        {
            if (input == null)
                return 0;

            int count = 0;

            string vowels = "aeiou";

            foreach (var ch in input.ToLower().ToCharArray())
            {
                if (vowels.Contains(ch))
                    count++;
            }

            return count;
        }

        public static string Reverse(string input)
        {
            if (input == null)
                return "";

            var reversed = new StringBuilder();

            for (int i = input.Length - 1; i >= 0; i--)
            {
                reversed.Append(input[i]);
            }

            return reversed.ToString();

        }

        public static string ReverseWords(string words)
        {
            if (words == null)
                return "";

            var array = words.Trim().Split(' ');
            //var revered = new StringBuilder();

            //for (int i = array.Length -1 ; i >= 0 ; i--)
            //{
            //    revered.Append(array[i] + " ");
            //}


            var another = array.Reverse();
            return string.Join(" ", another);


        }

        public static bool IsRorationString(string origional, string rotation)
        {
            if (origional == null || rotation == null)
                return false;

            return origional.Length == rotation.Length && (origional + rotation).Contains(rotation);
        }

        public static string RemoveDuplicates(string input)
        {
            List<char> seen = new List<char>();
            var output = new StringBuilder();

            foreach (var item in input.ToCharArray())
            {
                if (!seen.Contains(item))
                {
                    seen.Add(item);
                    output.Append(item);
                }
            }

            return output.ToString();

        }

        public static char FindMostRepeated(string input)
        {

            IDictionary<char, int> dic = new Dictionary<char, int>();
            foreach (var item in input.ToCharArray())
            {
                if (dic.ContainsKey(item))
                {
                    dic[item] += 1;
                }
                else
                    dic.Add(item, 1);
            }

            var ch = dic.Where(v => v.Value == dic.Values.Max()).Select(k => k.Key).SingleOrDefault();

            return ch;
        }

        public static bool isAnagram(string str1, string str2)
        {
            if (str1 == null || str2 == null)
                return false;

            var array1 = str1.ToLower().ToCharArray();
            var array2 = str2.ToLower().ToCharArray();

            System.Array.Sort(array1);
            System.Array.Sort(array2);

            return array1.SequenceEqual(array2);
        }

    }
}
