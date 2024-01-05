using System;
using System.Collections.Generic;
using System.Linq;

class Solution {
    public int solution(int[] ingredient) {
        int answer = 0;
        List<int> list = new List<int>();
        foreach (int burger in ingredient)
        {
            list.Add(burger);
            
            if (list.Count >= 4)
            {
                int[] patternToMatch = { 1, 2, 3, 1 };
        
                if (list.Skip(list.Count - 4).SequenceEqual(patternToMatch))
                {
                    answer++;
                    list.RemoveRange(list.Count - 4, 4);
                }
            }
        }

        return answer;
    }
}
