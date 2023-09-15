using System;
using System.Text;

public class Solution {
    public string solution(string s, string skip, int index) {
        StringBuilder answer = new StringBuilder();
        for(int i =0; i < s.Length; i++)
        {
            char currentChar = TransformCharacter(s[i], index, skip);
                answer.Append(currentChar);
        }
        return answer.ToString();
    }
     public char TransformCharacter(char c, int index, string skip)
    {
        const int alphabetSize = 26;
        int count = index;
        char transformedChar = c;

    for (int i = 1; i <= count; i++)
    {
        transformedChar++;

        // 알파벳 순환 처리
        if (transformedChar > 'z')
        {
            transformedChar = 'a';
        }

        // skip 문자열에 포함된 문자 건너뛰기
        while (skip.Contains(transformedChar.ToString()))
        {
            transformedChar++;

            // 알파벳 순환 처리
            if (transformedChar > 'z')
            {
                transformedChar = 'a';
            }
        }
    }

    return transformedChar;
    }
}