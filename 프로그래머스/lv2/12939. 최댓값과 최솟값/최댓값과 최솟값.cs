using System;
using System.Linq;

public class Solution {
    public string solution(string s) {
        string[] numbers = s.Split(' ');
        int[] intArray = numbers.Select(int.Parse).ToArray();
        int min = intArray.Min();
        int max = intArray.Max();
        
        string answer = $"{min} {max}";
        return answer;
    }
}