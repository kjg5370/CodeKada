using System;
public class Solution {
    public string solution(string s) {
        char[] charArray = s.ToCharArray();
        Array.Sort(charArray);
        Array.Reverse(charArray);
        string answer = new string(charArray);
        return answer;
    }
}