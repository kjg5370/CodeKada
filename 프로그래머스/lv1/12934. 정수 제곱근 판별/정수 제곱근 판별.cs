using System;

public class Solution {
    public long solution(long n) {
        long answer = 0;
        long sqrt = (long)Math.Sqrt(n); 
        if (sqrt * sqrt == n)
        {
            return (sqrt + 1) * (sqrt + 1);
        }
        else
        {
            return -1;
        }
       
            return answer;
    }
}