class Solution:
    def backspaceCompare(self, s: str, t: str) -> bool:
        return self.apply_backspace(s) == self.apply_backspace(t)

    def apply_backspace(self, s: str) -> str:
        lst = list(s)
        pos = 0
        for i in range(len(lst)):
            if lst[i] == '#':
                pos = self.backspace_position(pos)
            else:
                lst[pos] = lst[i]
                pos += 1

        return ''.join(lst[:pos])

    def backspace_position(self, i: int) -> int:
        if i > 0:
            return i - 1
        return i