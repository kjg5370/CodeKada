using System;

public class Solution {
    public int solution(int[,] sizes) {
        int answer = 0;
        int width =0;
        int height =0;
        for (int i = 0; i < sizes.GetLength(0); i++) {
            int w = sizes[i, 0];
            int h = sizes[i, 1];

            if (w < h) {
                int temp = w;
                w = h;
                h = temp;
            }

            width = Math.Max(width, w);
            height = Math.Max(height, h);
        }
        answer = width *height;
        return answer;
    }
}