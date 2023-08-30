using System;

public class Solution {
    public int solution(int[] number) {
        int answer = 0;
        int n = number.Length;
        for (int i = 0; i < n - 2; i++) {
            for (int j = i + 1; j < n - 1; j++) {
                for (int k = j + 1; k < n; k++) {
                    int sum = number[i] + number[j] + number[k];
                    if(sum ==0)answer++;
                }
            }
        }
        return answer;
    }
}