using System;

public class Solution {
    public int solution(string s) {
        int answer = 0;
        string[] numbers = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
        foreach(string num in numbers)
        {
            s = s.Replace(num, Array.IndexOf(numbers, num).ToString());
        }
        answer = int.Parse(s);
        return answer;
    }
}