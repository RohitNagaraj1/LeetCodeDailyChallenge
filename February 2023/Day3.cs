// 6. Zigzag Conversion

public class Solution {
    public string Convert(string s, int numRows) 
    {
        string result = "";
        StringBuilder[] sb = new StringBuilder[numRows];
        for (int i = 0; i < numRows; i++)
            sb[i] = new StringBuilder();
        
        for (int i = 0; i < s.Length; )
        {
            for (int j = 0; j < numRows; j++)
            {
                if (i < s.Length)
                    sb[j].Append(s[i++]);
            }

            for (int j = numRows-2; j > 0; j--)
            {
                if (i < s.Length)
                    sb[j].Append(s[i++]);
            }
        }

        for (int i = 0; i < numRows; i++)
        {
            result += sb[i].ToString();
        }

        return result;
    }
}