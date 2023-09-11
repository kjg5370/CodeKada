using System;
using System.Linq;

public class Solution {
    public int[] solution(int[] lottos, int[] win_nums) {
        int[] answer = new int[2];
        
        int count = lottos.Intersect(win_nums).Count();
        int zeroCount = lottos.Count(num => num == 0);
        answer[0] = count+zeroCount>1?7-(count+zeroCount):6;
        answer[1] = count>1?7-count:6;
        return answer;
    }
}