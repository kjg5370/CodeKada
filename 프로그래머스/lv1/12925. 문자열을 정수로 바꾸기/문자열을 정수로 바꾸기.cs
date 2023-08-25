public class Solution {
    public int solution(string s) {
        int answer = 0;
        if(s[0] == '-') {
             for(int i =1; i<s.Length;i++)
             {
                 answer = answer* 10 + s[i] -'0';
             }answer = -answer;
        }
        else
        {answer = int.Parse(s);}
        return answer;
    }
}