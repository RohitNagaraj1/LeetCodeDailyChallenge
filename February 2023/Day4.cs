// 567. Permutation in String

public class Solution {
    List<string> result;
    public bool CheckInclusion(string s1, string s2) 
    {
        if (s1.Length > s2.Length)
            return false;

        int[] s1Count = new int[26];
        int[] s2Count = new int[26];

        for (int i = 0; i < s1.Length; i++)
        {
            s1Count[s1[i]-'a']++;
            s2Count[s2[i]-'a']++;
        }

        if (IsMatch(s1Count, s2Count))
            return true;
        
        for (int i = s1.Length; i < s2.Length; i++)
        {
            s2Count[s2[i-s1.Length] - 'a']--;
            s2Count[s2[i]-'a']++;

            if (IsMatch(s1Count, s2Count))
                return true;
        }

        return false;
    }
    
    public bool IsMatch(int[] s1Count, int[] s2Count)
    {
        for (int i = 0; i < 26; i++)
        {
            if (s1Count[i] != s2Count[i])
                return false;
        }

        return true;
    }
}