public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        int n = temperatures.Length;
int[] result = new int[n];
Stack<int> stack = new Stack<int>(); // store indices, not values

for (int i = 0; i < n; i++)
{
    while (stack.Count > 0 && temperatures[i] > temperatures[stack.Peek()])
    {
        int idx = stack.Pop();
        result[idx] = i - idx;
    }
    stack.Push(i);
}

return result;
    }
}
