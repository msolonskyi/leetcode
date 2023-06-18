class ParkingSystem:

    def __init__(self, big: int, medium: int, small: int):
        self.spots = [big, medium, small]

    def addCar(self, carType: int) -> bool:
        self.spots[carType - 1] -= 1
        return self.spots[carType - 1] >= 0