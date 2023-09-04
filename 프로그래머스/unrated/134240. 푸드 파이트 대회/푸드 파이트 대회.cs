using System;
using System.Text;

public class Solution {
    public string solution(int[] food) {
        StringBuilder  answer = new StringBuilder();
        int foodCount = -1;
        for(int i =0; i <food.Length; i++)
        {
            foodCount += 1;
            for(int j = 0; j <food[i]/2; j++)
            {
                answer.Append(foodCount);                
            }
        }
        answer.Append(0);  
        for(int i =food.Length-1; i >=0; i--)
        {
            for(int j = 0; j <food[i]/2; j++)
            {
                answer.Append(foodCount);                
            }
            foodCount -= 1;
        }
        return answer.ToString();
    }
}