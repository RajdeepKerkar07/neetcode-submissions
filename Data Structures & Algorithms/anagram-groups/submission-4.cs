public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs)
{
    Dictionary<string, List<string>> map = new Dictionary<string, List<string>>();
    List<List<string>> result = new List<List<string>>();

    for (int i = 0; i < strs.Length; i++)
    {
        int[] count = new int[26];
        string word = strs[i];
        for (int j = 0; j < strs[i].Length; j++)
        {
            count[(int)word[j] - (int)'a'] += 1;
        }
        if (map.ContainsKey(string.Join(",", count)))
        {
            map[string.Join(",", count)].Add(strs[i]);
        }
        else
        {
            List<string> list = new List<string>();
            list.Add(strs[i]);
            map.Add(string.Join(",", count), list);
        }
    }
    foreach (var val in map.Values)
    {
        result.Add(val);
    }
    return result;
}
}
