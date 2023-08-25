public class Solution {
    public int[] solution(long n) {
        string str = n.ToString();
        int[] answer = new int[str.Length];
        
        for (int i = 0; i < str.Length; i++)
        {
            answer[i] = str[str.Length - 1 - i] - '0';
        }
            
        return answer;
    }
}