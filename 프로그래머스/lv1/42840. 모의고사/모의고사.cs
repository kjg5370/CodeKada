using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(int[] answers) {
       List<int> answer = new List<int>();
       int[] pattern1 = { 1, 2, 3, 4, 5 };
       int[] pattern2 = { 2, 1, 2, 3, 2, 4, 2, 5 };
       int[] pattern3 = { 3, 3, 1, 1, 2, 2, 4, 4, 5, 5 };
        
       int[] scores = new int[3];
        
       for (int i = 0; i < answers.Length; i++) {
           if (answers[i] == pattern1[i % pattern1.Length]) {
               scores[0]++;
           }
           if (answers[i] == pattern2[i % pattern2.Length]) {
               scores[1]++;
           }
           if (answers[i] == pattern3[i % pattern3.Length]) {
               scores[2]++;
           }
        }

        int maxScore = scores.Max();
        for (int i = 0; i < 3; i++) {
            if (scores[i] == maxScore) {
                answer.Add(i + 1);
            }
        }

        return answer.ToArray();;
    }
}