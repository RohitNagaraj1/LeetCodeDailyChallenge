// 944. Delete Columns to Make Sorted

public class Solution {
    public int MinDeletionSize(string[] strs) 
    {
        int n = strs[0].Length;
        int count = 0;

        for (int i = 0; i < n; i++)
        {
            char prev = strs[0][i];
            bool flag = true;

            for (int j = 0; j < strs.Length; j++)
            {
                if (strs[j][i] < prev)
                {
                    flag = false;
                    break;
                }
                else
                {
                    prev = strs[j][i];
                }
            }

            if (!flag)
                count++;
        }

        return count;
    }
}