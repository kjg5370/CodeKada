using System;

public class Solution {
    public string solution(string[] cards1, string[] cards2, string[] goal) {
        int index1 = 0, index2 = 0;

        foreach (var word in goal) {
            if (index1 < cards1.Length && word == cards1[index1]) {
                index1++;
            } else if (index2 < cards2.Length && word == cards2[index2]) {
                index2++;
            } else {
                return "No";
            }
        }

        return "Yes";
    }
}