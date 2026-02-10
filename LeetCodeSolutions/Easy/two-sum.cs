namespace LeetCodeSolutions.Easy;

public class two_sum
{
    // Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
    // You may assume that each input would have exactly one solution, and you may not use the same element twice.
    // You can return the answer in any order.
    
    public int[] TwoSum(int[] nums, int target) {
    
        //loop through each value and minus it from target
        for (int i = 0; i < nums.Length; i++) {
            int num = nums[i];
            int complement = target - num;
        
            //see if result is in list
            int foundIndex = Array.FindIndex<int>(nums, x => x == complement);
        
            //return index
            if (foundIndex != -1 && foundIndex != i) {
                return new int[] {i, foundIndex};
            }
        }
    
        return new int[] {};
    }
    
}