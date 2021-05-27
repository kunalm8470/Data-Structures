using binary_search_tree.Models;
using System;

namespace binary_search_tree
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] seed = { 1, 2, 3, 4, 6, 7, 8, 9, 11 };
            int left = 0;
            int right = seed.Length - 1;

            BinarySearchTreeExtensions<int> bstExt = new();
            BinarySearchTree<int> bst = new(bstExt.GenerateFrom(seed, left, right));

            while(true)
            {
                Console.WriteLine("BST Operations");
                Console.WriteLine("1. In-Order Traversal");
                Console.WriteLine("2. Pre-Order Traversal");
                Console.WriteLine("3. Post-Order Traversal");
                Console.WriteLine("4. Height of Binary Search Tree");
                Console.WriteLine("5. Search Binary Search Tree");
                Console.WriteLine("6. Print Leaf Nodes");
                Console.WriteLine("7. Insert node in BST");
                Console.WriteLine("0. Exit");
                Console.WriteLine("Enter choice (1-7): ");

                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("Enter valid input!");
                    return;
                }

                switch (choice)
                {
                    case 1:
                        bstExt.InOrderTraversal(bst.Root);
                        Console.WriteLine();
                        break;
                    case 2:
                        bstExt.PreOrderTraversal(bst.Root);
                        Console.WriteLine();
                        break;
                    case 3:
                        bstExt.PostOrderTraversal(bst.Root);
                        Console.WriteLine();
                        break;
                    case 4:
                        Console.WriteLine("Height of BST: {0}\n", bstExt.CalculateHeight(bst.Root));
                        break;
                    case 5:
                        Console.WriteLine("\nKey to search: ");
                        if (!int.TryParse(Console.ReadLine(), out int searchKey))
                        {
                            Console.WriteLine("Invalid search term!");
                            return;
                        }

                        if (bstExt.Contains(bst.Root, searchKey))
                            Console.WriteLine("{0} key present in BST", searchKey);
                        else
                            Console.WriteLine("{0} key absent in BST", searchKey);

                        break;
                    case 6:
                        bstExt.PrintLeafNodes(bst.Root);
                        break;
                    case 7:
                        Console.WriteLine("\nKey to add: ");
                        if (!int.TryParse(Console.ReadLine(), out int data))
                        {
                            Console.WriteLine("Invalid key to add!");
                            return;
                        }

                        bst = new BinarySearchTree<int>(bstExt.Insert(bst.Root, data));
                        Console.WriteLine("Node added!");
                        break;

                    case 0:
                    default:
                        Console.WriteLine("Exiting!");
                        return;
                }
            }
        }
    }
}
