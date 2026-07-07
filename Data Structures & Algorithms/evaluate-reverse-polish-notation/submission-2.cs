public class Solution {
    public int EvalRPN(string[] tokens) {
        if(tokens.Length < 1 || tokens.Length > 1000) return 0;
        Stack<int> expression = new Stack<int>();
        string[] operations = ["+", "-", "*", "/"];
        foreach(var c in tokens){
            if(operations.Contains(c)){
                int result = 0;
                switch(c){
                    case "+":
                        result = expression.Pop() + expression.Pop();
                        break;
                    case "-":
                        var temp2 = expression.Pop();
                        var temp1 = expression.Pop();
                        result = temp1 - temp2;
                        break;
                    case "*":
                        result = expression.Pop() * expression.Pop();
                        break;
                    case "/":
                        var sec = expression.Pop();
                        var fir = expression.Pop();
                        result = fir / sec;
                        break;
                }
                expression.Push(result);
            }
            else{
                expression.Push(Convert.ToInt32(c));
            }
        }
        return expression.Count == 1 ? expression.Peek() : 0;
    }
}
