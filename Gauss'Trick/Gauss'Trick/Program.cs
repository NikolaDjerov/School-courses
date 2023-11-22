﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gauss_Trick
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums1 = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList();
            List<int> nums2 = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList();
            List<int> resultNums = new List<int>();
            for (int i = 0; i < Math.Min(nums1.Count, nums2.Count); i++)
            {
                if (nums1.Count > nums2.Count)
                {
                    resultNums.AddRange(GetRemainingElements(nums1, nums2));
                }
                else if (nums2.Count > nums1.Count)
                {
                    resultNums.AddRange(GetRemainingElements(nums2, nums1));
                }
                Console.WriteLine(string.Join(" ", resultNums));
            }
            List<int> GetRemainingElements(List<int> longerList, List<int> shorterList)
            {
                List<int> nums = new List<int>();
                for (int i = shorterList.Count; i < longerList.Count; i++)
                    nums.Add(longerList[i]);
                return nums;
            }
        }
    }
}
