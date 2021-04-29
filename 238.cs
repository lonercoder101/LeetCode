//238. Product of Array Except Self
//c sharp

public class Solution {
    public int Length {get;}
    public int[] ProductExceptSelf(int[] nums) 
    {
        int len = nums.Length;
        int[] dp = new int[len]; //left pointer for product from left
        dp[0] =1;
        for(int i = 1; i<len;i++)
            dp[i] = dp[i-1] * nums[i-1];      // 1,2,3,4 -- 1,1,2,6
        
        int[] output = new int[len]; int res=1;
        
        for(int i=len-1;i>=0;i--)    // right pointer
        {
            output[i] = res*dp[i];        // 6*1, output[3] =6 
            res= res*nums[i]  ;      //1*4 = 4 so then next time output[2] = 4*2 = 8
        }
        return output;
    }
    
}
