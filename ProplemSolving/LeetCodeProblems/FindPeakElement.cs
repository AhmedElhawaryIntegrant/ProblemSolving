using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    
    public class FindPeakElement
    {
        public int PeakElement { get; set;}
        public int BinarySearch(int[] nums, int left, int right)
        {
            if (left == right)
                return left;
            int mid = (left + right) / 2;
            if (nums[mid] > nums[mid + 1])
                return BinarySearch(nums, left, mid);
            return BinarySearch(nums, mid + 1, right);
        }

        public FindPeakElement(int[] nums)
        {
            PeakElement = BinarySearch(nums, 0, nums.Length - 1);
        }
    }
}
