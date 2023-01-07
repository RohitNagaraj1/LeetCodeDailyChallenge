// 134. Gas Station

public class Solution {
    public int CanCompleteCircuit(int[] gas, int[] cost) {
        int n = gas.Length;
        int totalSum = 0;
        int rangeSum = 0;

        int candidate = 0;

        for (int i = 0; i < n; i++)
        {
            int diff = gas[i] - cost[i];
            totalSum += diff;
            rangeSum += diff;

            if (rangeSum < 0)
            {
                rangeSum = 0;
                candidate = i + 1;
            }
        }

        if (totalSum < 0)
            return -1;
        
        return candidate;
    }
}