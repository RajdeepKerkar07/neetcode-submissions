public class Solution {
    public bool IsPalindrome(string s) {
        s = string.Join("", s.Trim(' ').Where(c => char.IsLetterOrDigit(c))).ToLower();
int left = 0;
int right = s.Length - 1;

while (left < right)
{
    if (s[left] != s[right]) return false;
    else
    {
        left += 1;
        right -= 1;
    }
}
return true;
    }
}
