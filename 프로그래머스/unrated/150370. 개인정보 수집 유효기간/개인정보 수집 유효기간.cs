using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(string today, string[] terms, string[] privacies) {
        List<int> answer = new List<int>();
        DateTime todayDate = DateTime.ParseExact(today, "yyyy.MM.dd", null);
        
        Dictionary<string, int> termDict = new Dictionary<string, int>();
        foreach (string term in terms)
        {
            string[] parts = term.Split(' ');
            termDict[parts[0]] = int.Parse(parts[1]);
        }
        
        for(int i =0; i < privacies.Length; i++)
        {
            string[] info = privacies[i].Split(' ');
            string privacyDateStr = info[0];
            string privacyType = info[1];
            
            DateTime privacyDate = DateTime.ParseExact(privacyDateStr, "yyyy.MM.dd", null);
            
            int term = termDict[privacyType];
            
             if (todayDate >= privacyDate.AddMonths(term))
            {
                answer.Add(i + 1); 
            }
        }
        return answer.ToArray();
    }
}