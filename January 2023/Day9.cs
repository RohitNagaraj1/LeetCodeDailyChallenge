// 144. Binary Tree Preorder Traversal

public class Solution {
    public List<int> list = new List<int>();
    
    public IList<int> PreorderTraversal(TreeNode root) 
    {
        Pre(root);
        return list;
    }
    
    public void Pre(TreeNode root)
    {
        if (root == null)
            return;
        
        list.Add(root.val);
        Pre(root.left);
        Pre(root.right);
    }
}