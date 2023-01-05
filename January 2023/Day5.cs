//452. Minimum Number of Arrows to Burst Balloons

public class Solution {
    public int FindMinArrowShots(int[][] points) 
    {
        var list = points.OrderBy(i => i[1]).ThenBy(j => j[0]).ToArray();

        int[] point = new int[2];
        point[0] = list[0][0];
        point[1] = list[0][1];
        int count = 1;

        for (int i = 1; i < list.Length; i++)
        {
            if (list[i][0] <= point[1])
                continue;
            else
            {
                count++;
                point[0] = list[i][0];
                point[1] = list[i][1];
            }
        }

        return count;
    }
}