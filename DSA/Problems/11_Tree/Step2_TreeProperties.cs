using System;

namespace DSA.Problems.Tree
{
    // STEP 2: Tree properties (height, balance, diameter, BST, LCA, path sum, same tree)
    public class Step2_TreeProperties
    {
        public void Test(TreeNode root, TreeNode maxPathRoot)
        {
            Console.WriteLine("\n--- Tree Properties ---");
            Console.WriteLine("Max Depth: " + MaxDepth(root));
            Console.WriteLine("Is Balanced?: " + IsBalanced(root));
            Console.WriteLine("Diameter: " + DiameterOfBinaryTree(root));

            // LCA Test
            TreeNode p = root.left!;            // 5
            TreeNode q = root.left!.right!.right!; // 4
            Console.WriteLine("LCA of 5 and 4: " + LowestCommonAncestor(root, p, q)?.val); // 5

            Console.WriteLine("\n--- Advanced Properties ---");
            Console.WriteLine("Max Path Sum (-10 Tree): " + MaxPathSum(maxPathRoot)); // Expected: 42

            // Same Tree Test
            TreeNode treeA = new TreeNode(1);
            treeA.left = new TreeNode(2);

            TreeNode treeB = new TreeNode(1);
            treeB.left = new TreeNode(2);

            Console.WriteLine("Are Tree A and Tree B Same?: " + IsSameTree(treeA, treeB)); // True
        }

        // ═══════════════════════════════════════════════════════════
        // 3. HEIGHT, BALANCE & DIAMETER
        // ═══════════════════════════════════════════════════════════
        public int MaxDepth(TreeNode? root)
        {
            if (root == null) return 0;
            int leftHeight = MaxDepth(root.left);
            int rightHeight = MaxDepth(root.right);
            return Math.Max(leftHeight, rightHeight) + 1;
        }

        public bool IsBalanced(TreeNode? root)
        {
            if (root == null) return true;
            int leftMax = MaxDepth(root.left);
            int rightMax = MaxDepth(root.right);
            if (Math.Abs(leftMax - rightMax) > 1) return false;
            return IsBalanced(root.left) && IsBalanced(root.right);
        }

        private int maxDiameter = 0;
        public int DiameterOfBinaryTree(TreeNode? root)
        {
            maxDiameter = 0;
            CalculateHeight(root);
            return maxDiameter;
        }
        private int CalculateHeight(TreeNode? node)
        {
            if (node == null) return 0;
            int leftHeight = CalculateHeight(node.left);
            int rightHeight = CalculateHeight(node.right);
            maxDiameter = Math.Max(maxDiameter, leftHeight + rightHeight);
            return Math.Max(leftHeight, rightHeight) + 1;
        }

        // ═══════════════════════════════════════════════════════════
        // 4. BINARY SEARCH TREE (BST)
        // ═══════════════════════════════════════════════════════════
        public bool IsBST(TreeNode? root)
        {
            return IsValidBST(root, long.MinValue, long.MaxValue);
        }
        private bool IsValidBST(TreeNode? node, long min, long max)
        {
            if (node == null) return true;
            if (node.val <= min || node.val >= max) return false;
            return IsValidBST(node.left, min, node.val) && IsValidBST(node.right, node.val, max);
        }

        // ═══════════════════════════════════════════════════════════
        // 5. LOWEST COMMON ANCESTOR (LCA)
        // ═══════════════════════════════════════════════════════════
        public TreeNode? LowestCommonAncestor(TreeNode? root, TreeNode p, TreeNode q)
        {
            if (root == null) return null;
            if (root == p || root == q) return root;

            TreeNode? leftSearch = LowestCommonAncestor(root.left, p, q);
            TreeNode? rightSearch = LowestCommonAncestor(root.right, p, q);

            if (leftSearch != null && rightSearch != null) return root;
            return leftSearch ?? rightSearch;
        }

        // ═══════════════════════════════════════════════════════════
        // 6. MAXIMUM PATH SUM
        // ═══════════════════════════════════════════════════════════
        private int maxPathSum = int.MinValue;
        public int MaxPathSum(TreeNode? root)
        {
            maxPathSum = int.MinValue;
            CalculateMaxSum(root);
            return maxPathSum;
        }
        private int CalculateMaxSum(TreeNode? node)
        {
            if (node == null) return 0;
            int leftSum = Math.Max(0, CalculateMaxSum(node.left));
            int rightSum = Math.Max(0, CalculateMaxSum(node.right));
            maxPathSum = Math.Max(maxPathSum, leftSum + rightSum + node.val);
            return node.val + Math.Max(leftSum, rightSum);
        }

        // ═══════════════════════════════════════════════════════════
        // 7. SAME TREE
        // ═══════════════════════════════════════════════════════════
        public bool IsSameTree(TreeNode? p, TreeNode? q)
        {
            if (p == null && q == null) return true;
            if (p == null || q == null) return false;
            if (p.val != q.val) return false;
            return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
        }
    }
}
