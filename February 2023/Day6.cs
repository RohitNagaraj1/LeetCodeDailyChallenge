// 904. Fruit Into Baskets

public class Solution {
    public int TotalFruit(int[] fruits) 
    {
        Dictionary<int, int> map = new Dictionary<int, int>();
        int max = 0;

        int start = 0;
        int end = -1;

        while (end < fruits.Length-1)
        {
            end++;
            if (map.ContainsKey(fruits[end]))
            {
                map[fruits[end]]++;
            }
            else
            {
                map.Add(fruits[end], 1);
                if (map.Count() > 2)
                {
                    while (start < end && map.Count() > 2)
                    {
                        map[fruits[start]]--;
                        if (map[fruits[start]] == 0)
                            map.Remove(fruits[start]);
                        start++;
                    }
                }
            }
            max = Math.Max(max, end-start+1);
        }

        return max;
    }
}