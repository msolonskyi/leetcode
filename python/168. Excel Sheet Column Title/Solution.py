class Solution:
    def convertToTitle(self, columnNumber: int) -> str:
        LETTERS_IN_ATPHABET = 26
        result = ''
        while columnNumber > 0:
            columnNumber -= 1
            result = chr(columnNumber % LETTERS_IN_ATPHABET + ord('A')) + result
            columnNumber //= LETTERS_IN_ATPHABET
        return result