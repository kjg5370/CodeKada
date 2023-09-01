using System;
public class Solution {
    public string solution(string s, int n) {
        string answer = "";
        char[] alpha = s.ToCharArray();
        for(int i =0; i< alpha.Length;i++)
        {
            char c = alpha[i];
            if(char.IsLetter(c))
            {
                char baseChar = char.IsLower(c) ? 'a' : 'A';
                alpha[i] = (char)((((c-baseChar)+n)%26)+baseChar);
            }
        }
        answer = new String(alpha);
        return answer;
    }
}