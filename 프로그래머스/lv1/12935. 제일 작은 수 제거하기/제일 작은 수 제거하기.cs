using System;
using System.Linq;
public class Solution {
    public int[] solution(int[] arr) {
        if (arr.Length <= 1)return new int[] {-1};
        int minValue = arr.Min();
        int[] answer = Array.FindAll(arr, num => num != minValue).ToArray();
        return answer;
    }
}