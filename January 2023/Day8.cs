// 149. Max Points on a Line

public class Solution {
    public int MaxPoints(int[][] points) 
    {
        int n = points.Length;
        
        if (n < 2)
            return n;
        
        int max = 1;
        
        for (int i = 0; i < n; i++)
        {
            int[] a = points[i];
            var map = new Dictionary<double, int>();
            int localMax = 1;
            
            for (int j = i+1; j < n; j++)
            {
                double slope = GetSlope(a, points[j]);
                
                if (!map.ContainsKey(slope))
                {
                    map.Add(slope, 1);
                }
                map[slope]++;
                
                localMax = Math.Max(localMax, map[slope]);
            }
            
            max = Math.Max(max, localMax);
        }
        
        return max;
        
    }
    
    public bool IsSame(int[] a, int[] b)
    {
        return a[0] == b[0] && a[1] == b[1];
    }
    
    public double GetSlope(int[] a, int[] b)
    {
        // slope of a line = (Y2 - Y1)/(X2 -X1)
        if (a[0] == b[0])
            return Double.MaxValue;
        
        if (a[1] == b[1])
            return 0;
        
        return ((double) a[1] - b[1]) / ((double) a[0] - b[0]);
    }
}