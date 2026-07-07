public class MinStack {
    public Stack<int> minStack;
    public MinStack() {
        minStack = new Stack<int>();
    }
    
    public void Push(int val) {
        minStack.Push(val);
    }
    
    public void Pop() {
        minStack.Pop();
    }
    
    public int Top() {
        return minStack.Peek();
    }
    
    public int GetMin() {
        return minStack.Min();
    }
}
