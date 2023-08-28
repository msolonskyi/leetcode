class Solution:
    def furthestDistanceFromOrigin(self, moves: str) -> int:
        return max(self.calc(moves.replace('_', 'L')), self.calc(moves.replace('_', 'R')))
        
    def calc(self, moves: str) -> int:
        pos = 0
        for m in moves:
            if m == 'L': pos -= 1
            else: pos += 1
        return abs(pos)