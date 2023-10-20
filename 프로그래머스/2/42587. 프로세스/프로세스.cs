using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] priorities, int location) {
        int answer = 0;
        Queue<Tuple<int, int>> queue = new Queue<Tuple<int, int>>();
        for (int i = 0; i < priorities.Length; i++)
        {
            queue.Enqueue(new Tuple<int, int>(i, priorities[i]));
        }
        
        while (queue.Count > 0)
        {
            Tuple<int, int> current = queue.Dequeue();
            int currentIndex = current.Item1;
            int currentPriority = current.Item2;
            bool canPrint = true;

            foreach (Tuple<int, int> item in queue)
            {
                if (item.Item2 > currentPriority)
                {
                    canPrint = false;
                    break;
                }
            }

            if (canPrint)
            {
                answer++;
                if (currentIndex == location)
                {
                    break;
                }
            }
            else
            {
                queue.Enqueue(current);
            }
        }
        return answer;
    }
}