public class Solution {
    public bool IsAnagram(string s, string t) {
        string s_new = new string(s.OrderBy(c => c).ToArray());
        string t_new = new string(t.OrderBy(c => c).ToArray());
        if(s_new.Count() != t_new.Count()) return false;
        for(int i=0; i < s_new.Count(); i++)
        {
            if(s_new[i] != t_new[i]) return false;
        }
        return true;
    }
}