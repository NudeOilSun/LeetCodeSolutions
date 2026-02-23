namespace LeetCodeSolutions.Medium;

//Given a string s, find the length of the longest substring without duplicate characters.
// 
// Input: s = "abcabcbb"
// Output: 3
// Explanation: The answer is "abc", with the length of 3. Note that "bca" and "cab" are also correct answers.
public class Longest_Substring_Without_Repeating_Characters {
    
    public int LengthOfLongestSubstring(string s) {
        var chars = s.ToCharArray();
        var hashSet = new HashSet<char>();
        var longestLength = 0;
        int left = 0;
        
        for (int right = 0; right < s.Length; right++)
        {
            while (hashSet.Contains(s[right]))
            {
                hashSet.Remove(s[left]);
                left++;  
            }
    
            hashSet.Add(s[right]);
            if (hashSet.Count > longestLength)
            {
                longestLength = hashSet.Count;
            }
        }
        
        return longestLength;
    }
    
}