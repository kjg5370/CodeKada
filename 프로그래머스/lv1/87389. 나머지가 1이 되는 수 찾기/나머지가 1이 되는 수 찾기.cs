using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        int minX = n;
        for(int i = n; i >= 1; i--){
            if(n%i == 1 && i < minX)
                minX = i;
        }
        answer = minX;
        return answer;
    }
}