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
public class FindElements {
    TreeNode fixedTree = new();
    HashSet<int> nums = new();
    public FindElements(TreeNode root) {
        root.val = 0;
        nums.Add(0);
        Decontaminate(root);
        this.fixedTree = root;
    }

    public void Decontaminate(TreeNode node){
        if (node.left is not null){
            node.left.val = 2* node.val + 1;
            nums.Add(node.left.val);
            Decontaminate(node.left);
        }
        if (node.right is not null){
            node.right.val = 2* node.val + 2;
            nums.Add(node.right.val);
            Decontaminate(node.right);
        }
        
    }

    public bool Find(int target) {
        if(nums.Contains(target)) return true;
        return false;

    }
}

/**
 * Your FindElements object will be instantiated and called as such:
 * FindElements obj = new FindElements(root);
 * bool param_1 = obj.Find(target);
 */
