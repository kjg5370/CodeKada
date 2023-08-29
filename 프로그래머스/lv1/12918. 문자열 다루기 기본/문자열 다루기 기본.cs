public class Solution {
    public bool solution(string s) {
        bool answer = true;
        if (s.Length != 4 && s.Length != 6)
            return false;
        answer = int.TryParse(s, out _);
        return answer;
    }
}