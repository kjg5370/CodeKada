using System;

public class Solution {
    public string solution(string[] seoul) {
        string answer = "";
        int x = Array.IndexOf(seoul,"Kim");
        answer = $"김서방은 {x}에 있다";
        return answer;
    }
}