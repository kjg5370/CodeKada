public class Solution {
    public double solution(int[] arr) {
        double answer = 0;
        int sum = 0;
        foreach(int num in arr)
        {
            sum += num;
        }
        answer = (double)sum / arr.Length;
        return answer;
    }
}