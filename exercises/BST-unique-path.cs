/*

 * Definition for a binary tree node.
 * struct TreeNode {
 *     int val;
 *     TreeNode *left;
 *     TreeNode *right;
 *     TreeNode(int x) : val(x), left(NULL), right(NULL) {}
 * };

Calculate the number of unique paths from root to leaf in a BST.

                  1
                /   \
               2     3
              / \   / \
             2   N  N  N
            / \
           N  N
          
         
    Time complextiY: O(n) because we have to visit all the node
    Memory complexity: O(h) because the max call stack will be the height of the tree 
*/
class HelloWorld {
    static void Main() {
        System.Console.WriteLine("Hello World!");
        
        TreeNode root = new TreeNode(1, new TreeNode(2, new TreeNode(2)), new TreeNode(3));
        
        int result = Count_Unique_Path(root);
        Console.WriteLine(result);
    }
    
    static int Count_Unique_Path(TreeNode tree)
    {
        if (tree == null)
            return 0;

        int paths = 0;
        if ((tree.left == null) && (tree.right == null) ) //leaf node
           return 1; 
        
        
        paths += Count_Unique_Path(tree.left);
        paths += Count_Unique_Path(tree.right);
        
        return paths;
    }
}
