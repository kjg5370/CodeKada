using System;
public class Solution {
    public string[] solution(string[] strings, int n) {
        string[] answer = new string[strings.Length];
        Array.Copy(strings, answer, strings.Length);
        Array.Sort(answer, (a, b) =>  {
            if (a[n] == b[n])
                return string.Compare(a, b, StringComparison.Ordinal);
            return a[n].CompareTo(b[n]);
        });
        return answer;
    }
}