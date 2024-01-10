using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(int k, int[] tangerine) {
        Dictionary<int, int> frequencyMap = new Dictionary<int, int>();

        foreach (int size in tangerine)
        {
            if (!frequencyMap.ContainsKey(size))
            {
                frequencyMap[size] = 1;
            }
            else
            {
                frequencyMap[size]++;
            }
        }
        
        List<int> frequencies = frequencyMap.Values.ToList();
        frequencies.Sort();

        int result = 0;
        int uniqueCount = frequencies.Count;
        int sum = 0;

        while (sum < k)
        {
            sum += frequencies[--uniqueCount];
            result++;
        }

        return result;
    }
}