public class Solution {
    public bool IsValid(string s) {
        if (s.Length < 1 || s.Length > 1000 || s.Length % 2 != 0) return false;

        List<string> stack = new List<string>();

        foreach(var cc in s){
            string c = cc.ToString();
            if(c == "[" || c == "{" || c == "("){
                stack = Push(stack, c);
            }
            else{
                if((c == "}" && stack.Count > 0 && stack[^1] == "{")
                    || (c == "]" && stack.Count > 0 && stack[^1] == "[")
                    || (c == ")" && stack.Count > 0 && stack[^1] == "(")){
                    stack = Pop(stack);
                }
                else stack = Push(stack, c);
            }
        }
        return stack.Count == 0;
    }

    private List<string> Pop(List<string> str){
        str.RemoveAt(str.Count - 1);
        return str;
    }

    private List<string> Push(List<string> str, string element){
        str.Add(element);
        return str;
    }
}
