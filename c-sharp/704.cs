// 
// 704. Binary Search
// 

public class Solution {
    // Let 'n' be the length of nums
    // Time:    O(n)
    // Space:   O(1)
    public int Search(int[] nums, int target) {
        int left = 0;
        int right = nums.Length-1;
        int mid;

        while (left < right) {
            mid = (left + right) / 2;

            if (nums[mid] == target) {
                return mid;
            }
            else if (nums[mid] > target) {
                right = mid-1;
            }
            else {
                left = mid+1;
            }
        }

        if (nums[left] == target) {
            return left;
        }
        return -1;
    }
}
