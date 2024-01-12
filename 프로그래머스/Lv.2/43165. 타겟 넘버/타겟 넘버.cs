using System;

public class Solution {
    public int solution(int[] numbers, int target) {
        int answer = 0;
        DFS(numbers, target, 0, 0, ref answer);
        return answer;
    }

    private void DFS(int[] numbers, int target, int index, int currentSum, ref int answer) {
        if (index == numbers.Length) {
            if (currentSum == target) {
                answer++;
            }
            return;
        }
        DFS(numbers, target, index + 1, currentSum + numbers[index], ref answer);
        DFS(numbers, target, index + 1, currentSum - numbers[index], ref answer);
    }
}