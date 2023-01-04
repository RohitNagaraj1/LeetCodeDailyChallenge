// 2244. Minimum Rounds to Complete All Tasks

public class Solution {
    public int MinimumRounds(int[] tasks) {
        Dictionary<int, int> map = new Dictionary<int, int>();

        for (int i = 0; i < tasks.Length; i++)
        {
            if (!map.ContainsKey(tasks[i]))
                map.Add(tasks[i], 0);
            
            map[tasks[i]]++;
        }

        int count = 0;
        foreach (var item in map)
        {
            if (item.Value < 2)
                return -1;
            
            count += item.Value / 3;
            if (item.Value % 3 != 0)
                count++;
        }

        return count;
    }
}