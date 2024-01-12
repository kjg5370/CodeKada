using System;

public class Solution {
    public int solution(int n, int k) {
        int answer = 0;
        string converted = ConvertToKBase(n, k);
        
        int j = 0;
        for (int i = 0; i < converted.Length - 1; i = j) {
            for (j = i + 1; j < converted.Length && converted[j] != '0'; j++) ;
            if (IsPrime(long.Parse(converted.Substring(i, j - i))))
                answer++;
        }
        return answer;
    }

    private string ConvertToKBase(int number, int baseNumber) {
        string result = "";
        while (number > 0) {
            int remainder = number % baseNumber;
            result = remainder + result;
            number /= baseNumber;
        }
        return result;
    }

    private bool IsPrime(long num) {
        if (num < 2)
            return false;

        for (long i = 2; i * i <= num; i++) {
            if (num % i == 0)
                return false;
        }
        return true;
    }
}
