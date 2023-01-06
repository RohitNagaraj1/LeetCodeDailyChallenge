// 1833. Maximum Ice Cream Bars

public class Solution {
    public int MaxIceCream(int[] costs, int coins) {
        PriorityQueue<int, int> queue = new PriorityQueue<int, int>();

        for (int i = 0; i < costs.Length; i++)
            queue.Enqueue(costs[i], costs[i]);

        int count = 0;
        
        while (queue.Count > 0 && queue.Peek() <= coins)
        {
            count++;
            coins -= queue.Dequeue();
        }

        return count;
    }
}