class MyHashSet:

    def __init__(self):
        self.dict = {}

    def add(self, key: int) -> None:
        if not key in self.dict.keys():
            self.dict[key] = 0

    def remove(self, key: int) -> None:
        if key in self.dict.keys():
            del self.dict[key]

    def contains(self, key: int) -> bool:
        if key in self.dict.keys():
            return True
        return False