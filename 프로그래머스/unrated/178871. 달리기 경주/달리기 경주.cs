using System;
using System.Collections.Generic;

public class Solution {
    public string[] solution(string[] players, string[] callings) {
        Dictionary<string, int> playerIndexMap = new Dictionary<string, int>();
        for (int i = 0; i < players.Length; i++) {
            playerIndexMap[players[i]] = i;
        }

        string[] answer = players;

        foreach (string calling in callings) {
            int rank = playerIndexMap[calling];
            string temp = answer[rank - 1];
            answer[rank - 1] = answer[rank];
            answer[rank] = temp;
            
            playerIndexMap[calling] = rank - 1;
            playerIndexMap[answer[rank]] = rank;
        }

        return answer;
    }
}