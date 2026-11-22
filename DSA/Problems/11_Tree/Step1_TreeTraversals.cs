using System;
using System.Collections.Generic;

namespace DSA.Problems.Tree
{
    // STEP 1: Basic traversals (BFS + DFS, recursive and iterative)
    public class Step1_TreeTraversals
    {
        public void Test(TreeNode root)
        {
            Console.WriteLine("--- Traversals ---");
            Console.Write("LevelOrder: "); LevelOrder(root);
            Console.Write("PreOrder: "); PreOrder(root); Console.WriteLine();
            Console.Write("InOrder: "); InOrder(root); Console.WriteLine();
            Console.Write("PostOrder (Stack): "); PostOrderUsingStack(root); Console.WriteLine();

            //Console.Write("InOrder: "); InOrder(root); Console.WriteLine();
            //Console.Write("PostOrder: "); PostOrder(root); Console.WriteLine();
            //Console.Write("PreOrder (Stack): "); PreOrderUsingStack(root);
            //Console.Write("InOrder (Stack): "); InOrderUsingStack(root);
        }

        // ═══════════════════════════════════════════════════════════
        // 1. TRAVERSALS (BFS & DFS)
        // ═══════════════════════════════════════════════════════════
        public void LevelOrder(TreeNode? root)
        {
            if (root == null) return;
            Queue<TreeNode> q = new Queue<TreeNode>();
            q.Enqueue(root);
            while (q.Count > 0)
            {
                TreeNode node = q.Dequeue();
                Console.Write(node.val + " ");
                if (node.left != null) q.Enqueue(node.left);
                if (node.right != null) q.Enqueue(node.right);
            }
            Console.WriteLine();
        }

        public void PreOrder(TreeNode? root)
        {
            if (root == null) return;
            Console.Write(root.val + " ");
            PreOrder(root.left);
            PreOrder(root.right);
        }

        public void InOrder(TreeNode? root)
        {
            if (root == null) return;
            InOrder(root.left);
            Console.Write(root.val + " ");
            InOrder(root.right);
        }

        public void PostOrder(TreeNode? root)
        {
            if (root == null) return;
            PostOrder(root.left);
            PostOrder(root.right);
            Console.Write(root.val + " ");
        }

        // ═══════════════════════════════════════════════════════════
        // 2. ITERATIVE DFS (USING STACK)
        // ═══════════════════════════════════════════════════════════
        public void PreOrderUsingStack(TreeNode root)
        {
            if (root == null) return;
            Stack<TreeNode> stk = new Stack<TreeNode>();
            stk.Push(root);
            while (stk.Count > 0)
            {
                TreeNode node = stk.Pop();
                Console.Write(node.val + " ");
                if (node.right != null) stk.Push(node.right);
                if (node.left != null) stk.Push(node.left);
            }
            Console.WriteLine();
        }

        public void InOrderUsingStack(TreeNode root)
        {
            Stack<TreeNode> stk = new Stack<TreeNode>();
            TreeNode? node = root;
            while (true)
            {
                if (node != null)
                {
                    stk.Push(node);
                    node = node.left;
                }
                else
                {
                    if (stk.Count == 0) break;
                    node = stk.Pop();
                    Console.Write(node.val + " ");
                    node = node.right;
                }
            }
            Console.WriteLine();
        }

        public void PostOrderUsingStack(TreeNode root)
        {
            if (root == null) return;
            Stack<TreeNode> stk = new Stack<TreeNode>();
            List<int> result = new List<int>();
            stk.Push(root);

            while (stk.Count > 0)
            {
                TreeNode node = stk.Pop();
                result.Add(node.val);
                if (node.left != null) stk.Push(node.left);
                if (node.right != null) stk.Push(node.right);
            }
            result.Reverse();
            foreach (int val in result) Console.Write(val + " ");
            Console.WriteLine();
        }
    }
}
