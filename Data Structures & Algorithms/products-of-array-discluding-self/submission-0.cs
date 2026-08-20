public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] prefixArr = new int[nums.Length];
        int[] suffixArr = new int[nums.Length];
        int[] result = new int[nums.Length];

        prefixArr[0] = 1;
        for(int i = 1; i < nums.Length; i++){
            prefixArr[i] = prefixArr[i - 1] * nums[i - 1];
        }

        suffixArr[nums.Length - 1] = 1;
        for(int i = nums.Length - 2; i >= 0; i--){
            suffixArr[i] = suffixArr[i + 1] * nums[i + 1];
        }

        for(int i = 0; i < nums.Length; i++){
            result[i] = prefixArr[i] * suffixArr[i];
        }

        return result;
    }
}
