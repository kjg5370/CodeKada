using System;

public class Solution {
    public int[] solution(string s) {
        int[] answer = new int[2];
         while (s != "1") {
            int zeroCount = 0;
            string newS = "";

            foreach (char c in s) {
                if (c == '0') {
                    zeroCount++;
                } else {
                    newS += c;
                }
            }

            int length = newS.Length;
            s = Convert.ToString(length, 2);

            answer[0]++;
            answer[1] += zeroCount;
        }

        return answer;
    }
}