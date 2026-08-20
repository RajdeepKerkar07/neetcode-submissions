public class Solution {

    public string Encode(IList<string> strs) {
        StringBuilder res = new StringBuilder();
        foreach(var str in strs){
            res.Append(str.Length);
            res.Append("#");
            res.Append(str);
        }
        return res.ToString();
    }

    public List<string> Decode(string s) {
        int i = 0;
        List<string> res = new List<string>();

        while(i < s.Length){
            int j = i;

            while(s[j] != '#') j++;

            int length = int.Parse(s.Substring(i, j-i));

            j++;

            res.Add(s.Substring(j, length));

            i = j + length;
        }
        return res;
   }
}
