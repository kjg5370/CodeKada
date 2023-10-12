using System;
using System.Linq;

public class Solution {
    public int solution(int[] citations) {
        int answer = 0;
        Array.Sort(citations);
        for (int i = 0; i < citations.Length; i++) {
            int h = Math.Min(citations[i], citations.Length - i);
            answer = Math.Max(answer, h);
        }
        return answer;
    }
}