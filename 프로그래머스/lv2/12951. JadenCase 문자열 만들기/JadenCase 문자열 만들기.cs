public class Solution {
    public string solution(string s) {

        string[] words = s.Split(' ');
    
        for (int i = 0; i < words.Length; i++) {
            if (!string.IsNullOrEmpty(words[i])) {
                words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1).ToLower();
            }
        }


        string result = string.Join(" ", words);

        return result;
    }
}