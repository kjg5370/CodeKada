using System;

public class Solution {
    public int solution(int[] numbers) {
        int answer = 0;
        for(int i=0;i<10;i++)
        {
            if(Array.IndexOf(numbers,i) == -1)answer+=i;
        }
        return answer;
    }
}