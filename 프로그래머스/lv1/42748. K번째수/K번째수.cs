using System;

public class Solution {
    public int[] solution(int[] array, int[,] commands) {
        int numCommands = commands.GetLength(0);
        int[] answer = new int[numCommands];
        
        for (int i = 0; i < numCommands; i++)
        {
            int start = commands[i, 0] - 1;
            int end = commands[i, 1] - 1;
            int k = commands[i, 2];

            int[] sliced = new int[end - start + 1];
            Array.Copy(array, start, sliced, 0, sliced.Length);
            Array.Sort(sliced);

            answer[i] = sliced[k - 1];
        }
        
        return answer;
    }
}