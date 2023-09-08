using System;
using System.Collections.Generic;

class Solution
{
    public int solution(int[] nums)
    {
        int answer = 0;
        var sums = Combinations(nums, 3);

        foreach (var sum in sums)
        {
            if(CalcPrime(sum))
                answer++;
        }

        return answer;
    }
    public bool CalcPrime(int num) 
	{
		int nr = (int)Math.Sqrt(num); 
		for (int i = 2; i <= nr; i++) 
		{
			if (num % i == 0)
				return false; 
		} 
		return true; 
	}
    public List<int> Combinations(int[] arr, int r)
    {
        var result = new List<int>();
        GenerateSums(arr, 0, r, 0, new List<int>(), result);
        return result;
    }
    public void GenerateSums(int[] arr, int idx, int r, int currentSum, List<int> current, List<int> result)
    {
        if (current.Count == r)
        {
            result.Add(currentSum);
            return;
        }

        for (int i = idx; i < arr.Length; i++)
        {
            current.Add(arr[i]);
            GenerateSums(arr, i + 1, r, currentSum + arr[i], current, result);
            current.RemoveAt(current.Count - 1);
        }
    }
}