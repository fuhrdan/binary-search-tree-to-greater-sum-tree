//*****************************************************************************
//** 1038. Binary Search Tree to Greater Sum Tree  leetcode                  **
//** I worked on problems like these in college, but this answer came from   **
//** here: https://github.com/doocs/leetcode/blob/main/solution/1000-1099/   **
//** This was a good exercise, but  "I skipped leg day" for it -Dan          **
//*****************************************************************************


/**
 * Definition for a binary tree node.
 * struct TreeNode {
 *     int val;
 *     struct TreeNode *left;
 *     struct TreeNode *right;
 * };
 */
 
int doog(struct TreeNode* root, int sum)
{
    if(root)
    {
        sum = doog(root->right, sum) + root->val;
        root->val = sum;
        sum = doog(root->left, sum);
    }
    return sum;
}

struct TreeNode* bstToGst(struct TreeNode* root) {
    doog(root, 0);
    return root;
}
