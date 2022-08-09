using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Backup.Medium
{
    public class _189RotateArraySolution : Singleton<_189RotateArraySolution>
    {
        public void Rotate(int[] nums, int k)
        {

            //int[] result = new int[nums.Length];
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    result[(i+k)%nums.Length] = nums[i];
            //}
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    nums[i] = result[i];
            //}


            int temp = 0;
            for(int i = 0; i < nums.Length; i++)
            {
                if ((i + k) / nums.Length < 1) ;
            }

        }
    }
}
