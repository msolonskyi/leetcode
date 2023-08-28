class Solution:
    def splitWordsBySeparator(self, words: List[str], separator: str) -> List[str]:
        arr = separator.join(words)
        z = arr.split(separator)
        z = list(filter(lambda x : x != '', z))
        return z