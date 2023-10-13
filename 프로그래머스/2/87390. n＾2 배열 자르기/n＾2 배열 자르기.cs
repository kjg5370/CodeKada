using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int n, long left, long right) {
        List<int> answer = new List<int>();

        for (long i = left; i <= right; i++)
        {
            long row = i / n;
            long col = i % n;
            int maxDist = Math.Max((int)row, (int)col);
            answer.Add(maxDist + 1);
        }
        
        return answer.ToArray();
    }
}