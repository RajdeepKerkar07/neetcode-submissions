public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack<int> expression = new Stack<int>();
        string[] operations = ["+", "-", "*", "/"];
        foreach(var c in tokens){
            if(operations.Contains(c)){
                int result = 0;
                var temp2 = expression.Pop();
                var temp1 = expression.Pop();
                switch(c){
                    case "+":
                        result = temp1 + temp2;
                        break;
                    case "-":
                        result = temp1 - temp2;
                        break;
                    case "*":
                        result = temp1 * temp2;
                        break;
                    case "/":
                        result = temp1 / temp2;
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
