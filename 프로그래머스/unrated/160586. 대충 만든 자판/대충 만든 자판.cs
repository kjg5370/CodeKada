using System;

public class Solution {
    public int[] solution(string[] keymap, string[] targets) {
        int[] answer = new int[targets.Length];
        int sum = 0;
        int totalCount = 0;
        
        for(int i = 0; i < targets.Length; i++)
        {
            for(int j = 0; j < targets[i].Length; j++)
            {
                totalCount = press(keymap, targets[i][j]);
                if(totalCount == -1)
                {
                    sum = -1;
                    break;
                }
                sum += totalCount;
            }
            answer[i] = sum;
            sum = 0;
        }
        
        
        return answer;
    }
    public int press(string[] keymap, char ch)
    {
        int count = -1;
        
        for(int i = 0; i < keymap.Length; i++)
        {
            for(int j = 0; j < keymap[i].Length; j++)
            {
                if(keymap[i][j] == ch)
                {
                    if(count == -1)   count  = j + 1;
                    else if(count > j)    count  = j + 1;
                    break;
                }
            }
        }
        return count;
    }
}