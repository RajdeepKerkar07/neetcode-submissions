public class Solution {
    public int[] GetConcatenation(int[] nums) {
        int[] result = new int[2 * nums.Length];

        for(int i = 0; i < result.Length; i++){
            result[i] = nums[i % nums.Length];
        }

        return result;
    }
}