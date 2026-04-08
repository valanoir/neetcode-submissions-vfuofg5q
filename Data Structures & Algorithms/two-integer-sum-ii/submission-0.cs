public class Solution {
    public int[] TwoSum(int[] numbers, int target)
{
    int i = 0;
    int j = 1;
    while (i < numbers.Length)
    {
        if (j >= numbers.Length)
        {
            i++;
            j = i + 1;
            continue;
        }
        if (numbers[i] + numbers[j] == target)
        {
            return new int[] { i+1, j+1 };
        }
        j++;
    }
    return new int[] { -1, -1 };
}
}


// public class Solution { 
//     public int[] TwoSum(int[] numbers, int target) {
//         int i=0; int j=0;

//         if(i==j){
//             j++;
//         }

//         while(i!=j){

//         }
//     }
// }
