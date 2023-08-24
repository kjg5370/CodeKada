namespace algorithm
{
    internal class EvenOdd
    {
        static void Main(string[] args)
        {
            Solution sol1 = new Solution();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{sol1.solution(i)}");
            }
        }
    }

    public class Solution
    {
        public string solution(int num)
        {
            string answer = "";
            answer = num % 2 == 0 ? "Even" : "Odd";
            return answer;
        }
    }
}