using System;
using System.Collections.Generic;

public class Solution {
    public int solution(string s)
    {
        int answer = 0;
        int n = s.Length;

        for (int i = 0; i < n; i++)
        {
            string rotatedS = RotateString(s, i);
            if (IsValid(rotatedS))
            {
                answer++;
            }
        }

        return answer;
    }

    private string RotateString(string s, int count)
    {
        return s.Substring(count) + s.Substring(0, count);
    }

    private bool IsValid(string s)
    {
        Stack<char> stack = new Stack<char>();

        foreach (char c in s)
        {
            if (c == '(' || c == '[' || c == '{')
            {
                stack.Push(c);
            }
            else
            {
                if (stack.Count == 0)
                {
                    return false;
                }

                char openBracket = stack.Pop();

                if (c == ')' && openBracket != '(')
                {
                    return false;
                }
                else if (c == ']' && openBracket != '[')
                {
                    return false;
                }
                else if (c == '}' && openBracket != '{')
                {
                    return false;
                }
            }
        }

        return stack.Count == 0;
    }
}