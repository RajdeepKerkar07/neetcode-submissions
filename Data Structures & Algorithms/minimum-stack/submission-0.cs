public class MinStack {
    public List<int> minStack {get; set;}
    public MinStack() {
        minStack = new List<int>();
    }
    
    public void Push(int val) {
        minStack.Add(val);
    }
    
    public void Pop() {
        minStack.RemoveAt(minStack.Count - 1);
    }
    
    public int Top() {
        return minStack[^1];
    }
    
    public int GetMin() {
        return minStack.Min();
    }
}
