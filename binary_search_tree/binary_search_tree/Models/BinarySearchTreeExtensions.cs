using binary_search_tree.Interfaces;
using System;

namespace binary_search_tree.Models
{
    public class BinarySearchTreeExtensions<T> : IBinarySearchTree<T> where T : IComparable<T>
    {
        public void InOrderTraversal(Node<T> node)
        {
            if (node == default)
                return;

            InOrderTraversal(node.Left);
            Console.Write("{0}->", node.Data);
            InOrderTraversal(node.Right);
        }

        public void PreOrderTraversal(Node<T> node)
        {
            if (node == default)
                return;

            Console.Write("{0}->", node.Data);
            PreOrderTraversal(node.Left);
            PreOrderTraversal(node.Right);
        }

        public void PostOrderTraversal(Node<T> node)
        {
            if (node == default)
                return;

            PostOrderTraversal(node.Left);
            PostOrderTraversal(node.Right);
            Console.Write("{0}->", node.Data);
        }

        public Node<T> GenerateFrom(T[] arr, int left, int right)
        {
            if (left > right)
                return default;

            int mid = left + (right - left) / 2;
            Node<T> root = new(arr[mid]);

            root.Left = GenerateFrom(arr, left, mid - 1);
            root.Right = GenerateFrom(arr, mid + 1, right);
            return root;
        }

        public void PrintLeafNodes(Node<T> root)
        {
            if (root == default)
                return;

            // Leaf nodes have left and right nodes as null
            if (root.Left == default && root.Right == default)
                Console.Write("{0}, ", root.Data);

            // Recurse into left subtree
            PrintLeafNodes(root.Left);

            // Recurse into right subtree
            PrintLeafNodes(root.Right);
        }

        public Node<T> Insert(Node<T> root, T data)
        {
            if (root == default)
                return new Node<T>(data);

            if (root.Data.CompareTo(data) > 0)
                root.Left = Insert(root.Left, data);
            else
                root.Right = Insert(root.Right, data);

            return root;
        }

        public bool Contains(Node<T> root, T key)
        {
            if (root == default)
                return false;

            if (root.Data.Equals(key))
                return true;

            // Search left sub-tree
            if (root.Data.CompareTo(key) > 0)
                return Contains(root.Left, key);

            // Search right sub-tree
            return Contains(root.Right, key);
        }

        public int CalculateHeight(Node<T> root)
        {
            if (root == default)
                return 0;

            int leftSubTreeHeight = CalculateHeight(root.Left);
            int rightSubTreeHeight = CalculateHeight(root.Right);

            return Math.Max(leftSubTreeHeight, rightSubTreeHeight) + 1;
        }
    }
}
