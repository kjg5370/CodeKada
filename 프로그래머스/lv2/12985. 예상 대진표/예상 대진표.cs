using System;

class Solution
{
    public int solution(int n, int a, int b)
    {
        int answer = 1;

       while (true) {
           
            if (Math.Abs(a - b) == 1 && (a / 2 != b / 2)) {
                return answer;
            }

            a = (a + 1) / 2;
            b = (b + 1) / 2;
            answer++;
       }
    }
}