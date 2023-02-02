// 953. Verifying an Alien Dictionary

public class Solution {
    public bool IsAlienSorted(string[] words, string order) 
    {
        var map = new Dictionary<char, char>();
        int j = 0;
        for (char ch = 'a'; ch <= 'z'; ch++)
        {
            map.Add(order[j], ch);
            j++;
        }
        List<string> list = new List<string>();

        foreach (var word in words)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var w in word)
            {
                sb.Append(map[w]);
            }
            list.Add(sb.ToString());
        }
        
        var list2 = new List<string>(list);
        list2.Sort(StringComparer.Ordinal);

        for (int i = 0; i < words.Length; i++)
        {
            if (list2[i] != list[i])
                return false;
        }

        return true;
    }
}