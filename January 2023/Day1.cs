// 290. Word Pattern

public class Solution {
    public bool WordPattern(string pattern, string s) 
    {
        var sl = s.Split(" ").ToList();
        
        if(sl.Count() != pattern.Length)
            return false;
        
        var dicKV = new Dictionary<char, string>();
        int count = -1;
        
        foreach(var c in pattern)
        {
            count++;
            
           if(!dicKV.ContainsKey(c))
           {
               if(!dicKV.ContainsValue(sl[count]))
               {
                   dicKV.Add(c, sl[count]);
               }
               else
               {
                   return false;
               }
           }
            else
            {
                if(dicKV[c] != sl[count])
                    return false;
            }
        }
        
        return true;
        
    }
}