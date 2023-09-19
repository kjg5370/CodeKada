using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public string solution(string[] survey, int[] choices) {
        string answer = "";
        Dictionary<char, int> scoreMapping = new Dictionary<char, int>()
        {
            { 'R', 0 },
            { 'T', 0 },
            { 'C', 0 },
            { 'F', 0 },
            { 'J', 0 },
            { 'M', 0 },
            { 'A', 0 },
            { 'N', 0 }
        };
        
        for(int i = 0; i<choices.Length; i++)
        {
            char choice = survey[i][0];
            int score = Math.Abs((choices[i] - 4));
            
            if(choices[i] > 4)
            {
                choice = survey[i][1];
                score = choices[i] - 4;
            }
            scoreMapping[choice] += score;
        }
        answer += scoreMapping['R'] >= scoreMapping['T'] ? "R" : "T";
        answer += scoreMapping['C'] >= scoreMapping['F'] ? "C" : "F";
        answer += scoreMapping['J'] >= scoreMapping['M'] ? "J" : "M";
        answer += scoreMapping['A'] >= scoreMapping['N'] ? "A" : "N";
        return answer;
    }
}