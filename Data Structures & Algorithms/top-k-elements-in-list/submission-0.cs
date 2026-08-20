public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> uniqueNumbers = new Dictionary<int, int>();
// Count the frequency of each number in the input array
foreach (var num in nums)
{
    if(uniqueNumbers.ContainsKey(num))
    {
        uniqueNumbers[num]++;
    }
    else
    {
        uniqueNumbers[num] = 1;
    }
}

//  Create buckets to group numbers by their frequency
List<int>[] buckets = new List<int>[nums.Length + 1];
foreach (var pair in uniqueNumbers)
{
    int frequency = pair.Value;
    if (buckets[frequency] == null)
    {
        buckets[frequency] = new List<int>();
    }
    buckets[frequency].Add(pair.Key);
}

// Collect the top k frequent elements from the buckets
List<int> result = new List<int>();
for (int i = buckets.Length - 1; i >= 0 && result.Count < k; i--)
{
    if (buckets[i] != null)
    {
        result.AddRange(buckets[i]);
    }
}

return result.ToArray();
    }
}
