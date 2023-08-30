using System.Text;
public class Solution {
    public string solution(string s) {
        StringBuilder answer = new StringBuilder();
        int wordIndex = 0;
       for (int i = 0; i < s.Length; i++) {
            char c = s[i];
           
           if (c == ' ') {
                answer.Append(c);
                wordIndex = 0;
             } else {
                answer.Append(wordIndex % 2 == 0 ? char.ToUpper(c) : char.ToLower(c));
                wordIndex++;
            }
       }
        return answer.ToString();;
    }
}