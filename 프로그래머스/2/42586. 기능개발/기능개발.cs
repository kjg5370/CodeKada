using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] progresses, int[] speeds) {
        
        List<int> answer = new List<int>();
        
        int day = 0;
        int count = 0;
        
        for (int i = 0; i < progresses.Length; i++) {
            int remainingDays = (100 - progresses[i] + (speeds[i] - 1)) / speeds[i];
            if (remainingDays > day) {
                if (count > 0) {
                    answer.Add(count);
                    count = 0;
                }
                day = remainingDays;
            }
            count++;
        }
        
        if (count > 0) {
            answer.Add(count);
        }
        
        return answer.ToArray();
    }
}