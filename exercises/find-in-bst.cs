/* 
* Definition for a binary tree node.
 * struct TreeNode {
 *     int val;
 *     TreeNode *left;
 *     TreeNode *right;
 *     TreeNode(int x) : val(x), left(NULL), right(NULL) {}
 * };
 
 Search for a value in a BST
 
 
                  5
                /   \
               3     9
              / 
             2   
        
        
    Time complextiY: O(h) because worse case of a skewed tree max height needs to visited
    Memory complexity: O(h) because the max call stack will be the height of the tree 

 */

class HelloWorld {
    static void Main() {
        System.Console.WriteLine("Hello World!");
        
        
        TreeNode root = new TreeNode(5, new TreeNode(3, new TreeNode(2)), new TreeNode(9));
        
        
        bool result = Find_Value_In_BST(root, 4);
        Console.WriteLine(result);
        
    }
    
    static bool Find_Value_In_BST(TreeNode tree, int val)
    {
        if (tree == null)
            return false;
        
        if (tree.val == val)
            return true;
        if ( val < tree.val)
            return Find_Value_In_BST(tree.left,val);
        else
            return Find_Value_In_BST(tree.right,val);
       
    }
    
    
}
