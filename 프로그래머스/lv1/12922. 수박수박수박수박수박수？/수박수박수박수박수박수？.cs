using System.Text;

public class Solution {
    public string solution(int n) {
        StringBuilder answer = new StringBuilder();
        char su = '수';
        char bak = '박';
        for(int i =0; i< n; i++)
        {
           char currentChar = (i % 2 == 0) ? su : bak;
           answer.Append(currentChar);
        }
        return answer.ToString();
    }
}