# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right
class Solution:
    def maxLevelSum(self, root: Optional[TreeNode]) -> int:
        self.dic = {}
        lvl = 1
        self.get_value(lvl, root)
        ordered_values = [v[0] for v in sorted(self.dic.items(), key=lambda item: (-item[1], item[0]))]
        print(self.dic)
        print(ordered_values)
        return ordered_values[0]

    def get_value(self, lvl: int, node: Optional[TreeNode]):
        if not node:
            return
        if lvl in self.dic:
            self.dic[lvl] += node.val
        else:
            self.dic[lvl] = node.val
        
        if node.left: self.get_value(lvl + 1, node.left)
        if node.right: self.get_value(lvl + 1, node.right)