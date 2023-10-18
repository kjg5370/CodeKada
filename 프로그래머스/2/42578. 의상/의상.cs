using System;
using System.Collections.Generic;

public class Solution {
    public int solution(string[,] clothes) {
       int answer = 1;

        Dictionary<string, int> clothesCount = new Dictionary<string, int>();

        for (int i = 0; i < clothes.GetLength(0); i++) {
            string clothName = clothes[i, 0];
            string clothType = clothes[i, 1];

            if (clothesCount.ContainsKey(clothType)) {
                clothesCount[clothType]++;
            } else {
                clothesCount[clothType] = 1;
            }
        }

        foreach (var count in clothesCount.Values) {
            answer *= (count + 1);
        }

        answer--;

        return answer;
    }
}