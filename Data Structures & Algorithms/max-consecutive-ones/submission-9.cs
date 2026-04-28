public class Solution 
{ public int FindMaxConsecutiveOnes(int[] nums) { 
    int max = 0, current = 0; 
    foreach (int n in nums) 
    { if (n == 1) { 
        current++; max = Math.Max(max, current); 
        } else { current = 0; } 
        } 
        return max; 
        }
}
            
        