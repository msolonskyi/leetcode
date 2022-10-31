public class Solution {
    public bool HaveConflict(string[] event1, string[] event2) {
        return string.Compare(event1[0], event2[1]) <= 0 && string.Compare(event2[0], event1[1]) <= 0;
    }
}