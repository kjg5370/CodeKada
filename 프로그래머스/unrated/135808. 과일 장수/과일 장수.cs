using System;

public class Solution {
    public int solution(int k, int m, int[] score) {
        int answer = 0;
        Array.Sort(score);
        for(int i=0; i<score.Length/m; i++)
        {
            int maxScore = score[score.Length - m * (i + 1)];
            answer += maxScore * m;
        }
        return answer;
    }
}