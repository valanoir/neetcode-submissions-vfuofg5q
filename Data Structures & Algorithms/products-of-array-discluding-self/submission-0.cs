public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int i=0;
        int prod = 1;
        int zeroCount = 0;
	    for(i=0;i<nums.Length;i++){
            if(nums[i]==0){
                zeroCount++;
            }
            else{
                prod=prod*nums[i];
            }
        }

        for(i =0;i<nums.Length;i++){
            if(zeroCount > 1){
                nums[i]=0;
            }
            else if(zeroCount ==1){
                if(nums[i]==0){
                    nums[i]=prod;
                }
                else{
                    nums[i]=0;
                }
            }
            else{
                nums[i]=prod/nums[i];
            }
        }

        return nums;
    }
}
