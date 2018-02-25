using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class TreeNode
    {
        TreeNode Left;
        TreeNode Right;
        int data;

        public TreeNode(int data)
        {
            this.data = data;
            Left = null;
            Right = null;
        }

        public void add(int data, TreeNode root)
        {
            if(root.data == data)
            {
                return;
            }
            else if(root.data > data)
            {
                if (root.Left == null)
                {
                    root.Left = new TreeNode(data);
                }
                else
                {
                    add(data, root.Left);
                }
            }
            else if(root.data < data)
            {
                if (root.Right == null)
                {
                    root.Right = new TreeNode(data);
                }
                else
                {
                    add(data, root.Right);
                }
            }
        }

        public void print(TreeNode root)
        {
            if (root == null) return;
            print(root.Left);

            Console.Write(root.data);
            print(root.Right);
        }

        public void preOrder(TreeNode root)
        {
            TreeNode current = root;
            Stack<TreeNode> s = new Stack<TreeNode>();
            bool done = false;
            int max = 0;
            while (!done)
            {
                if(current != null)
                {
                    s.Push(current);
                    max = current.data;
                    current = current.Left;                   
                }
                else
                {
                    if (s.Count > 0)
                    {
                        current = s.Pop();
                        if(max > current.data)
                        {
                            Console.WriteLine("Not BST");
                            break;
                        }
                        Console.Write(current.data);
                        max = current.data;
                        current = current.Right;
                    }
                    else done = true;
                }

            }
        }
    }
}
