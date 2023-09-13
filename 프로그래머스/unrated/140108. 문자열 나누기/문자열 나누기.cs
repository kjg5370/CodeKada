using System;

public class Solution {
    public int solution(string s) {
        int answer = 0;
        int startIndex = 0;
        while (startIndex < s.Length) {
            char x = s[startIndex]; 
            int countX = 0;
            int countNotX = 0;
            int currentIndex = startIndex;

            while (currentIndex < s.Length) {
                if (s[currentIndex] == x) {
                    countX++;
                } else {
                    countNotX++;
                }

                if (countX == countNotX) {
                    break;
                }

                currentIndex++;
            }
            answer++;

            startIndex = currentIndex + 1;
        }

        return answer;
    }
}