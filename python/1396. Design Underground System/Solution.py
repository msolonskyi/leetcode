class UndergroundSystem:

    def __init__(self):
        self.openTrips = {}
        self.stationPairs = {}

    def checkIn(self, id: int, stationName: str, t: int) -> None:
        self.openTrips[id] = (stationName, t) 

    def checkOut(self, id: int, stationName: str, t: int) -> None:
        startStation, timeStart = self.openTrips[id]
        del self.openTrips[id]

        pair = startStation + "-" + stationName
        if pair in self.stationPairs:
            time, quantity = self.stationPairs[pair]
            self.stationPairs[pair] = [time + t - timeStart, quantity + 1]
        else:
            self.stationPairs[pair] = [t - timeStart, 1]

    def getAverageTime(self, startStation: str, endStation: str) -> float:
        pair = self.stationPairs[startStation + "-" + endStation]
        return pair[0]/pair[1]