using System;

public class Solution {
    public int solution(string t, string p) {
        int answer = 0;
        for(int i =0; i< t.Length - p.Length+1; i++)
        {
            string str1 = t.Substring(i,p.Length);
            
            if(string.Compare(str1,p) <=0)
                answer++; 
        }
        return answer;
    }
}