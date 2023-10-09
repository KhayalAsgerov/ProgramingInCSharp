using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrograminExercise5
{
    internal class EX2
    {
        public int[] MaxTreeValue(params int[] nums)
        { 
         Array.Sort(nums);
            int[] result = { nums[0], nums[1], nums[2] };
            return result;
        }
    }
}
