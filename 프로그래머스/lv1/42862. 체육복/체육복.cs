using System;
using System.Linq;

public class Solution {
    public int solution(int n, int[] lost, int[] reserve) {
        int[] students = new int[n];
        for (int i = 0; i < n; i++) {
            students[i] = 1;
        }
        
        foreach (int l in lost) {
            students[l - 1]--;
        }
        
        foreach (int r in reserve) {
            students[r - 1]++;
        }
        
        for (int i = 0; i < n; i++) {
            if (students[i] == 0) {
                if (i - 1 >= 0 && students[i - 1] == 2) {
                    students[i]++;
                    students[i - 1]--;
                } else if (i + 1 < n && students[i + 1] == 2) {
                    students[i]++;
                    students[i + 1]--;
                }
            }
        }
        
        int answer = students.Count(x => x > 0);
        
        return answer;
    }
}