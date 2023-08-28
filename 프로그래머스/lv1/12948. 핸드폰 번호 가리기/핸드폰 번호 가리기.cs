public class Solution {
    public string solution(string phone_number) {
        string answer = "";
        int length = phone_number.Length;
        answer = new string('*', length - 4) + phone_number.Substring(length - 4);
        return answer;
    }
}