using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrograminExercise5
{
    internal class EX1
    {
        public int[] SortedDescendingOrder(params int[] arr)
        { 
            int[] ret = new int[arr.Length];
        for (int i = 0; i < arr.Length; i++)
            {
                int check = arr[i];
                for (int j=0; j < arr.Length; j++)
                {
                    if (check> arr[j])
                    {
                        ret[i] = check ;
                    }
                    else
                    {
                        ret[i] = arr[j];
                        check= arr[j];
                    }
                    
                }
                for (int k = 0; k < arr.Length; k++)
                {
                    if ((ret[i] == arr[k]))
                    { arr[k] = 0; }
                }
               
            }
        return ret; 
        }

        public Array SortedAscendingOrder(params int[] nums)
        {
      Array.Sort(nums);
  
            return nums;
   
        }
        public Array SortedAscendingOrder(params string[] text)
        {
            Array.Sort(text);

            return text;

        }




    }
}
