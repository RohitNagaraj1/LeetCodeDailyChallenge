// 1071. Greatest Common Divisor of Strings

public class Solution {
    public string GcdOfStrings(string str1, string str2) 
    {
        string result = "";
        for (int i = str2.Length; i > 0; i--)
        {
            
            string sub = str2.Substring(0, i);
            if (IsValidSplit(sub, str2))
            {
                if (IsValidSplit(sub, str1))
                {
                    return sub;
                }
            }
        }

        return result;
    }

    public bool IsValidSplit(string s1, string s2)
    {
        if (s2.Length % s1.Length != 0)
            return false;
        
        string temp = "";
        for (int i = 0; i < s2.Length / s1.Length; i++)
        {
            temp += s1;
        }

        return temp == s2;
    }
}