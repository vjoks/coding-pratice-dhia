/**
 * Definition for a binary tree node.
 * struct TreeNode {
 *     int val;
 *     TreeNode *left;
 *     TreeNode *right;
 *     TreeNode(int x) : val(x), left(NULL), right(NULL) {}
 * };
 Question: Count the frequency of a key in a Binary Tree. (not BST)
                  1
                /   \
               2     3
              / \
             4   5
             
        stack: []     
In terms of n where n is the number of nodes
  Time Complexity : O(n) - since we visit all the nodes, worse case is O(n)
  Memory complexity: O(h) - worse case will be height of the tree as the max call stack will be the height of the tree
 */

class HelloWorld {
    //static int Count_Result;
    static void Main() {
        
        TreeNode root = new TreeNode(1, new TreeNode(2, new TreeNode(2)), new TreeNode(3));     

        int result = Count(root,  3);
        
        Console.WriteLine(result);
        
    }
    
    static int Count(TreeNode tree, int find_value)
    {

        int sum = 0;
        if (tree==null)
            return 0;
        if(tree.val == find_value)
        {
            sum++;
        };
        sum += Count(tree.left,  find_value);
        sum += Count(tree.right,  find_value);
        return sum;
    }
}
