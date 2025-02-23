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
        TreeNode root = new ();
        int[] preorder = [];
        int[] postorder = [];

    public TreeNode ConstructFromPrePost(int[] preorder, int[] postorder) {
        this.preorder = preorder;
        this.postorder = postorder;
        recursion(root);
        return root;
    }

    public int[] recursion(TreeNode active)
    {   
        active.val = preorder[0];
        if (preorder.Length == 1) return [];
        

        if (preorder[0] != postorder[0]){
            if (preorder.Length > 1)
            preorder = preorder[1..];
            else return [];
            active.left = new TreeNode();
            preorder = recursion(active.left);
            
            if (preorder.Length > 0 && postorder[0] != active.val){
                active.right = new TreeNode();
                preorder = recursion(active.right);
            } 
            else {
                postorder = postorder[1..];
                return preorder;
            }
        }

        else {
            Console.WriteLine("leaf at " + preorder[0].ToString());
            if (preorder.Length > 1)
            preorder = preorder[1..];
            else return [];
        
        }
        if (active.val == postorder[0] && postorder.Length > 1)
        postorder = postorder[1..];
        else return [];

        return preorder;

    }


}
