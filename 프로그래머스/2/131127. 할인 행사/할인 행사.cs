using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(string[] want, int[] number, string[] discount) {
       Dictionary<string, int> wantDict = new Dictionary<string, int>();
        for (int i = 0; i < want.Length; i++)
        {
            wantDict[want[i]] = number[i];
        }

        int answer = 0;
        int discountLength = discount.Length;

        for (int start = 0; start <= discountLength - 10; start++)
        {
            Dictionary<string, int> tempWantDict = new Dictionary<string, int>(wantDict);

            for (int i = start; i < start + 10; i++)
            {
                if (tempWantDict.ContainsKey(discount[i]) && tempWantDict[discount[i] ] > 0)
                {
                    tempWantDict[discount[i]]--;
                }
            }

            if (tempWantDict.Values.All(val => val == 0))
            {
                answer++;
            }
        }

        return answer;
    }
}