public class Solution {
    public bool hasDuplicate(int[] nums) {
        foreach(var num in nums){
            var number = num;
            if(nums.Count(x => x == number) > 1) return true;
        }
        return false;
    }
}