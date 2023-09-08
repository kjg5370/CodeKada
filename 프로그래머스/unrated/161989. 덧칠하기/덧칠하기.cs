using System;

public class Solution {
    public int solution(int n, int m, int[] section) {
        int answer = 0;
        int currentIndex = 0;

        while(currentIndex < section.Length)
        {
            int currentSection = section[currentIndex];

            int maxCoveredSection = currentSection + m - 1;

            while (currentIndex < section.Length && section[currentIndex] <= maxCoveredSection)
            {
                currentIndex++;
            }
            answer++;
        }
        return answer;
    }
}