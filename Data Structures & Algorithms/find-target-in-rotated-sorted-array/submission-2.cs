public class Solution {
    public int Search(int[] nums, int target) {
        int left = 0;
        int right = nums.Length-1;

        // find pivot
        while(left < right){
        int mid = (left + right)/2;
            if(nums[mid]>nums[right]){
                left = mid+1;
            }
            else
            {
                right = mid;
            }
        }

        // pivot found on the left 
        int pivot = left;
        int result = BinarySearch(nums, target,0,pivot-1);
        if(result != -1){
            return result;
        }
        return BinarySearch(nums,target,pivot,nums.Length-1);
    }


    public int BinarySearch(int[] nums, int target, int left, int right){
        while(left<=right){
            int mid = (left+right)/2;
            if(nums[mid] == target){
                return mid;
            }
            else if(nums[mid]<target){
                left = mid+1;
            }
            else{
                right = mid-1;
            }
        }
        return -1;
    }
}
