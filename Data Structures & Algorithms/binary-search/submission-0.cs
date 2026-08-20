public class Solution {
    public int Search(int[] nums, int target) {
        int mid = nums.Length / 2;
        int left = 0;
        int right = nums.Length - 1;
        while (left <= right)
        {
            if(nums[mid] == target)
            {
                return mid;
            }
            else if (nums[mid] < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
            mid = left + (right - left) / 2;
        }
        return -1;
    }
}
