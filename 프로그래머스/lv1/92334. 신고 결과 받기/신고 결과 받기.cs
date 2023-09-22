using System;
using System.Linq;
using System.Collections.Generic;
 
public class Solution {
    
    public int[] solution(string[] id_list, string[] report, int k) {
        
        Dictionary<string, List<string>> reportedIds = new Dictionary<string, List<string>>();
        Dictionary<string, int> reportedCount = new Dictionary<string, int>();
        
        report = report.Distinct().ToArray();
        
        for(int i = 0; i < report.Length; i++){
            string[] reportSplit = report[i].Split(' ');
            string reportId = reportSplit[0];
            string reportedId = reportSplit[1];
            
            if (reportedIds.ContainsKey(reportId))
                reportedIds[reportId].Add(reportedId);
            else
                reportedIds.Add(reportId, new List<string> {reportedId});
            
            if (reportedCount.ContainsKey(reportedId))
                reportedCount[reportedId]++;
            else
                reportedCount.Add(reportedId, 1);
        }
        
               
        List<int> answerList = new List<int>();
 
        for(int i = 0; i < id_list.Length; i++){
            int sendCount = 0;
            
            if(reportedIds.ContainsKey(id_list[i])){
                for(int j = 0; j < reportedIds[id_list[i]].Count; j++){
                    string reportedId = reportedIds[id_list[i]][j];
                    if(reportedCount.ContainsKey(reportedId)){
                        if(reportedCount[reportedId] >= k){
                            sendCount++;
                        }
                    }
                }
            }
            
            answerList.Add(sendCount);
        }
 
        int[] answer = answerList.ToArray();
        
        return answer;
    }
}