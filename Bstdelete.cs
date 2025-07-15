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
    public TreeNode DeleteNode(TreeNode root, int key) {
                if (root is null) return null;
        if (root.val == key){return handleDelete(root);}
        else if (root.val < key)
        {root.right = DeleteNode(root.right,key);}
        else if (root.val > key) 
        {root.left = DeleteNode(root.left,key);}
        return root;
    }

    public TreeNode handleDelete(TreeNode root){
        if (root.right is null){
            return root.left;
        }
        else if (root.left is null){
            return root.right;
        }
        TreeNode temp = root.right;
        TreeNode prev = root;
        bool goneLeft = false;
        while (temp.left is not null){
            prev = temp;
            temp = temp.left;
            goneLeft = true;
        }
        if (goneLeft){
        if (temp.right is not null) prev.left = temp.right;
        else prev.left = null;
            }
        else {if (temp.right is not null) prev.right = temp.right;
            else prev.right = null;}
        return new TreeNode(temp.val, root.left,root.right);
    }
}
