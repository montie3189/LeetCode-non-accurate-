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
    public IList<int> RightSideView(TreeNode root) {
        if (root is null) return [];
        IList<int> sol = new List<int> ([root.val]);
        
        Queue<Tuple<TreeNode,int>> nodes = new Queue<Tuple<TreeNode,int>>();
        nodes.Enqueue(new Tuple<TreeNode,int>(root,1));

        while(nodes.Count>0){
            var tupleFetch = nodes.Dequeue();
            var node = tupleFetch.Item1;
            var count = tupleFetch.Item2;
            if (count > sol.Count) sol.Add(node.val);
           if(node.right is not null){
                nodes.Enqueue(new Tuple<TreeNode,int>(node.right,count+1));
            }
            if(node.left is not null){
               nodes.Enqueue(new Tuple<TreeNode,int>(node.left,count+1));
            }
            
        }
return sol;
    }
}
