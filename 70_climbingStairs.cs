/*You are climbing a staircase. It takes n steps to reach the top.
Each time you can either climb 1 or 2 steps. In how many distinct ways can you climb to the top?
Dynamic Programming - bottom up
The total number of ways to reach ith is equal to sum of ways of reaching (i-1)th and (i-2)th
*/

public class Solution {
    public int ClimbStairs(int n) {
        if(n==1){
            return 1;
        }
        
        int[] dp = new int[n+1];
        dp[1] = 1;
        dp[2] = 2;
        
        for(int i=3;i<=n;i++){
            dp[i] = dp[i-1] + dp[i-2];
        }
        
        return dp[n];
    }
    
}
/*
https://www.youtube.com/watch?v=Y0lT9Fck7qI
Complicated dp, as we don't need an array
for n=5
8,5,3,2,1,1
we cans hift one and two backwords going in dp way
*/
public class Solution {
    public int ClimbStairs(int n) {
        if(n==1){
            return 1;
        }
        
        int oneStep = 1;
        int twoStep = 1;
        
        for(int i=1; i<n;i++){
            int temp = oneStep;
            oneStep = oneStep + twoStep;
            twoStep = temp;
        }
        
        return oneStep;
    }
    
}