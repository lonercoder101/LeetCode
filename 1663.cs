
//1663. Smallest String With A Given Numeric Value
//c sharp

public class Solution {
    public string GetSmallestString(int n, int k) {
        char[] output = new char[n];
        int i,ans;
        for(i=n-1;i>=0;i--)
        {
             ans = Math.Min( k-i , 26);
             output[i] = (char)(96+ans);
            k = k-ans;
        }
        string str = new string(output);
        return str;
        
    }
}
