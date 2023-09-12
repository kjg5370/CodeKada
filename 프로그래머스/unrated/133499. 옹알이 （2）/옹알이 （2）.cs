using System;
using System.Linq;

public class Solution {
    public int solution(string[] babbling) {
        int answer = 0;
        string[] temp = new string[4]{"aya", "ye", "woo", "ma"};
        string str = "";
        
        for(int i = 0; i < babbling.Length; i++)
        {
            for(int j = 0; j < temp.Length; j++)
            {
                str = temp[j] + temp[j];
                babbling[i] = babbling[i].Replace(str, "1");
                babbling[i] = babbling[i].Replace(temp[j], " ");
            }
            if(babbling[i].Trim().Length == 0)
            {
                answer++;
            }
        }
        
        return answer;
    }
}