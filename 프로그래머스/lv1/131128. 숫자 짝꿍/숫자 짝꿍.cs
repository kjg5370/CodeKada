using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public string solution(string X, string Y) {
        string answer = "";

        char[] digits = X.Intersect(Y).ToArray();

        if (digits.Length == 0)
        {
            answer = "-1";
        }
        else if (digits.Length == 1 && digits[0] == '0')
        {
            answer = "0";
        }
        else
        {
            List<char> answerList = new List<char>();
            foreach (char digit in digits)
            {
                int countX = X.Count(ch => ch == digit);
                int countY = Y.Count(ch => ch == digit);
                int minCount = Math.Min(countX, countY);

                for (int i = 0; i < minCount; i++)
                {
                     answerList.Add(digit);
                }
            }
           answerList.Sort();
            answerList.Reverse();
            answer = new string(answerList.ToArray());
        }

        return answer;
    }
}