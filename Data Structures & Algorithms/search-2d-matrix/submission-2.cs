public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int i=0;
        int j=0;
        while(i<matrix.Length){
            int left =0;
            int right = matrix[i].Length-1;
            while(left<=right){
                int mid=(left+right)/2;
                if(matrix[i][mid]==target){
                    return true;
                }
                else if(matrix[i][mid]<target){
                    left = mid+1;
                }
                else{
                    right=mid-1;
                }
            }
            i++;
        }
        return false;
    }
}
