// 45. Jump Game II

public class Solution {
    public int Jump(int[] nums) 
    {
        int max = 0;
        int steps = 0;
        int nextMax = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            int current = nums[i] + i;

            nextMax = Math.Max(nextMax, current);
            if (i >= max && i != nums.Length-1)
            {
                steps++;
                max = nextMax;
            }
        }

        return steps;
    }
}