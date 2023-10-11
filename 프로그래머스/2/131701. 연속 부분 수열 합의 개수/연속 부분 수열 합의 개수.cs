using System;
using System.Collections.Generic;

class Solution {
    public int solution(int[] elements) {
        int n = elements.Length;
        HashSet<int> uniqueSums = new HashSet<int>();

        for (int i = 0; i < n; i++) {
            int sum = 0;
            for (int j = 0; j < n; j++) {
                sum += elements[(i + j) % n]; 
                uniqueSums.Add(sum);
            }
        }

        return uniqueSums.Count;
    }
}
