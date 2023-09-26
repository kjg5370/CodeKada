using System;

public class Solution {
    public int[] solution(int brown, int yellow) {
        int[] answer = new int[2];
        int total = brown + yellow;
        
         for (int i = 1; i <= total; i++) {
            if (total % i == 0) {
                int width = total / i;
                int height = i;

                if ((width - 2) * (height - 2) == yellow) {
                    answer[0] = width;
                    answer[1] = height;
                    break;
                }
            }
        }
        
        return answer;
    }
}