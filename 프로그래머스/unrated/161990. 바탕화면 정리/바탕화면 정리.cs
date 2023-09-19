using System;

public class Solution {
    public int[] solution(string[] wallpaper) {
        int[] answer = new int[4];
        bool ischeck =false;
        answer[1] = wallpaper[0].Length;
        for(int i =0; i < wallpaper.Length; i++)
        {
            int index = wallpaper[i].IndexOf('#');
            if(ischeck == false && index != -1)
            {
                answer[0] = i;
                ischeck = true;
            }
            if(index != -1)
            {
                answer[1] = Math.Min(answer[1],index);
            }
        }
        answer[3] = 0;
        for(int i =0; i < wallpaper.Length; i++)
        {
            int index = wallpaper[i].LastIndexOf('#');
            if(index != -1)
            {
                answer[2] = i+1;
                answer[3] = Math.Max(answer[3],index+1);
            }
        }
            
        return answer;
    }
}