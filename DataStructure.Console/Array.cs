using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Console
{
    public class Array
    {
        
        int[] array = null;
        int index;
        
        public Array(int size)
        {
            array = new int[size];           
        }

        public void insert(int item)
        {
            if(array.Length != index)            
                array[index++] = item;
            else
            {
                var newArray =  new int[array.Length *2];
                array.CopyTo(newArray,0);
                array = newArray;
                array[index++] = item;
            }
        }

        public void removeAt(int removeIndex)
        {
            if (removeIndex < 0 || removeIndex >= index)
                throw new ArgumentOutOfRangeException();

            index -= 1;
            for (int i = removeIndex; i < index; i++)
            {
                array[i] = array[i + 1];
            }
        }

        public int indexOf(int item)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (item == array[i])
                    return i;
            }

            return -1;
        }

        public int max()
        {
            int max=0;

            for (int i = 0; i < index; i++)
            {
                if (max < array[i])
                    max = array[i];
            }

            return max;
        }

        public int[] intersect(int[] secondArray)
        {
            var list = new List<int>();
           

            for (int i = 0; i < secondArray.Length; i++)
            {
                if (indexOf(secondArray[i]) == 1)
                {
                    list.Add(secondArray[i]);                    
                }
            }

            return list.ToArray();
        }

        public void reverse()
        {
            var list = new List<int>();

            for (int i = array.Length -1; i >= 0 ; i--)
            {
                list.Add(array[i]);
            }

            array = list.ToArray();
        }

        public void Display()
        {
            for (int i = 0; i < index; i++)
            {
                System.Console.WriteLine(array[i]);
            }
        }



    }
}
