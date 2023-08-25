using System;
using System.Linq;

public class Solution {
    public long solution(long n) {
        long answer = 0;
        char[] digits = n.ToString().ToCharArray();
        Array.Sort(digits);
        string reversed = new string(digits.Reverse().ToArray());
        answer = long.Parse(reversed);
        return answer;
    }
}