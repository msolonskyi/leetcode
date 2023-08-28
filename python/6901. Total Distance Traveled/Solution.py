class Solution:
    def distanceTraveled(self, mainTank: int, additionalTank: int) -> int:
        currentMainTank = mainTank
        currentAdditionalTank = additionalTank
        distance = 0
        while currentMainTank > 0:
            if currentMainTank >= 5:
                distance += 50
                currentMainTank -= 5
                if currentAdditionalTank > 0:
                    currentAdditionalTank -= 1
                    currentMainTank += 1
            else:
                distance += 10 * currentMainTank
                currentMainTank = 0

        return distance