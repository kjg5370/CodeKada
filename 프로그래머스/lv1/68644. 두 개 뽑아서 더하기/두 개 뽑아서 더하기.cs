using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(int[] numbers) {
        HashSet<int>answer = new HashSet<int>();
        for(int i=0; i< numbers.Length -1; i++)
        {
            for(int j =i+1; j< numbers.Length; j++)
            {
                answer.Add(numbers[i]+numbers[j]);
            }
        }
        return answer.OrderBy(x =>x).ToArray();
    }
}