using System;

public class Solution {
    public string solution(int a, int b) {
        string answer = "";
        string[] daysOfWeek = { "SUN", "MON", "TUE", "WED", "THU", "FRI", "SAT" };
        DateTime date = new DateTime(2016, a, b);
        answer = daysOfWeek[(int)date.DayOfWeek];
        return answer;
    }
}