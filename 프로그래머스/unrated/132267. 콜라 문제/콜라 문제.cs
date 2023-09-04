using System;

public class Solution {
   private static int answer = 0;

    public int solution(int a, int b, int n) {
        answer = 0;
        return cola(a, b, n);
    }

    private int cola(int a, int b, int n) {
        if (n >= a) {
            int additionalCola = (n / a) * b;
            answer += additionalCola;
            n = (n % a) + additionalCola;
            return cola(a, b, n);
        } else {
            return answer;
        }
    }
}