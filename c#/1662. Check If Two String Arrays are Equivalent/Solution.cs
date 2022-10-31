public class Solution {
    public bool ArrayStringsAreEqual(string[] word1, string[] word2) {
        return string.Join(string.Empty, word1).Equals(string.Join(string.Empty, word2));
    }
}