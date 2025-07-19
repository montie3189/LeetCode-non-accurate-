/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public int MaxLevelSum(TreeNode root) {
        if (root is null) return 0;

        int maxSum = root.val;
        int maxLevel = 1;
        int runningTotal = 0;
        int currentLevel = 0;
        Queue<Tuple<TreeNode,int>> nodes = new Queue<Tuple<TreeNode,int>> ();
        nodes.Enqueue(new Tuple<TreeNode,int> (root,0));
        
        while (nodes.Count > 0){
            var fetched = nodes.Dequeue();
            var node = fetched.Item1;
            var level = fetched.Item2;
            if (level> currentLevel) {
                currentLevel = level;
                if (runningTotal > maxSum){
                    maxSum = runningTotal;
                    maxLevel = currentLevel;
                }
                runningTotal = 0;
            }
            runningTotal+= node.val;
            if(node.right is not null){
                nodes.Enqueue(new Tuple<TreeNode,int>(node.right,currentLevel+1));
                }
               if(node.left is not null){
                nodes.Enqueue(new Tuple<TreeNode,int>(node.left,currentLevel+1));
            }
            
        }
                       if (runningTotal > maxSum){
                    maxSum = runningTotal;
                    maxLevel = currentLevel +1;
                }
            return maxLevel;
        
    }
}
