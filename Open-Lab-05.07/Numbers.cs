using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Open_Lab_05._07
{
    public class Numbers
    {
        public int[] RemoveSmallest(int[] nums)
        {
            List<int> ret = new List<int>();
            int smallest = nums[0];
            bool once = false;
            foreach (int num in nums) if (num < smallest) smallest = num;
            for(int i = 0; i < nums.Length; i++)
            {
                if(nums[i] == smallest && !once)
                    once = true;

                else
                    ret.Add(nums[i]);

            }
            return ret.ToArray();
        }
    }
}
