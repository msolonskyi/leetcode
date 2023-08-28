class Solution:
    def largestAltitude(self, gain: List[int]) -> int:
        currentAltitude = 0
        highestAltitude = 0
        for altitude in gain:
            currentAltitude += altitude
            if currentAltitude > highestAltitude:
                highestAltitude = currentAltitude
        return highestAltitude