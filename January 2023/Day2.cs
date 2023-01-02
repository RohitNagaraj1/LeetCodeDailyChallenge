// 520. Detect Capital

public class Solution {
    public bool DetectCapitalUse(string word) 
    {
        if (word[0] >= 'a' && word[0] <= 'z')
        {
            for (int i = 1; i < word.Length; i++)
            {
                if (word[i] >= 'A' && word[i] <= 'Z')
                {
                    return false;
                }   
            }
            return true;
        }
        else
        {
            int count = 0;
            for (int i = 1; i < word.Length; i++)
            {
                if (word[i] >= 'A' && word[i] <= 'Z')
                {
                    count++;
                }  
            }
            return (count == 0) || (count == (word.Length-1));
        }
    }
}