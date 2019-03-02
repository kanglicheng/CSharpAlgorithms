using System;
using System.Collections.Generic;
public class ThreeSumClosest {
/* 
Given an array S of n integers, find three integers in S such that the sum is 
closest to a given number, target. Return the sum of the three integers.
 You may assume that each input would have exactly one solution.

    For example, given array S = {-1 2 1 -4}, and target = 1.

    The sum that is closest to the target is 2. (-1 + 2 + 1 = 2).*/


// Similar to 3 Sum problem, use 3 pointers to point current element, 
//next element and the last element. If the sum is less than target, it 
// means we have to add a larger element so next element move to the next.
//  If the sum is greater, it means we have to add a smaller element so 
//  last element move to the second last element. Keep doing this until the 
//  end. Each time compare the difference between sum and target, if it is less
//   than minimum difference so far, then replace result with it, otherwise keep 
//   iterating.
    public int ThreeSumClosest(int[] nums, int target) {
        int result = nums[0] + nums[1] + nums[nums.Length - 1];
        Array.Sort(nums);
        for (int i = 0; i < nums.Length - 2; i++) {
            int start = i + 1, end = nums.Length - 1;
            while (start < end) {
                int sum = nums[i] +nums[start] + nums[end];
                if (sum > target) {
                    end--;
                } else {
                    start++;
                }
                if (Math.Abs(sum - target) < Math.Abs(result - target)) {
                    result = sum;
                }
            }
        }
        return result;
    }
}