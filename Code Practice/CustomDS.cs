using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Practice
{
    public class DoubleLinkNode
    {
        public DoubleLinkNode prev;
        public DoubleLinkNode next;
        public int data;

        public DoubleLinkNode(int data)
        {
            prev = null;
            next = null;
            this.data = data;
        }

        public DoubleLinkNode addToEnd(int data)
        {
            if (next != null)
            {
                return next.addToEnd(data);
            }
            else
            {
                DoubleLinkNode temp = new DoubleLinkNode(data);
                next = temp;
                temp.prev = this;
                return temp;
            }
        }

        public void remove(int data)
        {
            if (next != null)
            {
                if (next.data == data)
                {
                    next.next.prev = this;
                    this.next = next.next;
                    return;
                }
                next.remove(data);
            }
        }

        public void print()
        {
            Console.Write("|" + data + "|<=>");
            if (next != null)
            {
                next.print();
            }
        }
    }

    public class DoublyLinkedList
    {
        public DoubleLinkNode headNode;
        public DoubleLinkNode tailNode;

        public DoublyLinkedList()
        {
            headNode = null;
            tailNode = null;
        }

        public void addToEnd(int data)
        {
            if (headNode == null)
            {
                headNode = new DoubleLinkNode(data);
                tailNode = headNode;
            }
            else
            {
                tailNode = headNode.addToEnd(data);
            }
        }

        public void print()
        {
            if (headNode == null)
            {
                Console.WriteLine("Empty List");
            }

            else
            {
                headNode.print();
            }
        }

        public void printReverse()
        {
            DoubleLinkNode current = tailNode;
            if (current == null)
            {
                Console.WriteLine("Empty list");
            }

            else
            {
                do
                {
                    Console.Write("|" + current.data + "|<=>");
                    current = current.prev;
                } while (current != null);
            }
        }

        public void remove(int data)
        {
            if (headNode == null)
            {
                Console.WriteLine("Empty List");
                return;
            }
            else if (headNode.data == data)
            {
                headNode.next.prev = null;
            }
            else if (tailNode.data == data)
            {
                tailNode.prev.next = null;
            }
            else
            {
                headNode.remove(data);
            }


        }
    }

    public class LinkedList
    {
        public SingleLinkNode headNode;

        public LinkedList()
        {
            headNode = null;
        }
        public void AddToEnd(int data)
        {
            if (headNode == null)
            {
                headNode = new SingleLinkNode(data);
            }
            else
            {
                headNode.addToEnd(data);
            }
        }

        public void AddSorted(int data)
        {
            if (headNode == null)
            {
                headNode = new SingleLinkNode(data);
            }
            else if (data < headNode.data)
            {
                AddToBegining(data);
            }
            else
            {
                headNode.AddSorted(data);
            }
        }

        public void AddToBegining(int data)
        {
            if (headNode == null)
            {
                headNode = new SingleLinkNode(data);
            }
            else
            {
                SingleLinkNode temp = new SingleLinkNode(data);
                temp.next = headNode;
                headNode = temp;

            }
        }

        public void reverse()
        {
            if (headNode == null)
            {
                return;
            }
            SingleLinkNode prev = null;
            SingleLinkNode current = headNode;
            SingleLinkNode next = current.next;
            while (next != null)
            {
                current.next = prev;
                prev = current;
                current = next;
                next = current.next;
            }
            headNode = prev;
            AddToBegining(current.data);
        }

        public int getMax()
        {
            if (headNode == null)
            {
                return Int32.MinValue;
            }
            else
            {
                return headNode.getMax();
            }
        }

        public void Print()
        {
            if (headNode != null)
            {
                headNode.print();
            }
        }
    }

    public class SingleLinkNode
    {
        public SingleLinkNode next;
        public int data;

        public SingleLinkNode(int data)
        {
            this.data = data;
            next = null;
        }
        public void addToEnd(int data)
        {
            if (next == null)
            {
                next = new SingleLinkNode(data);
            }
            else
            {
                next.addToEnd(data);
            }
        }
        public void AddSorted(int data)
        {
            if (next == null)
            {
                next = new SingleLinkNode(data);
            }
            else if (data < next.data)
            {
                SingleLinkNode temp = new SingleLinkNode(data);
                temp.next = this.next;
                this.next = temp;
            }
            else
            {
                next.AddSorted(data);
            }
        }

        public int getMax()
        {
            int max = this.data;
            SingleLinkNode current = next;
            while (current != null)
            {
                if (current.data > max)
                {
                    max = current.data;
                }
                current = current.next;
            }
            return max;
        }
        public void print()
        {
            Console.Write("|" + data + "| ->");
            if (next != null)
            {
                next.print();
            }
        }
    }

    public class TreeNode
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
            if (root.data == data)
            {
                return;
            }
            else if (root.data > data)
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
            else if (root.data < data)
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
                if (current != null)
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
                        if (max > current.data)
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

    public class Tree
    {
        TNode top;

        public Tree()
        {
            top = null;
        }

        public Tree(int data)
        {
            top = new TNode(data);
        }

        public void add(int data)
        {
            if (top == null)
            {
                top = new TNode(data);
            }
            TNode currentNode = top;
            bool added = false;
            do
            {
                if (data < currentNode.data)
                {
                    // go left
                    if (currentNode.left == null)
                    {
                        TNode newNode = new TNode(data);
                        currentNode.left = newNode;
                        added = true;
                    }
                    else
                    {
                        currentNode = currentNode.left;
                    }
                }
                else
                {
                    // go right
                    if (currentNode.right == null)
                    {
                        TNode newNode = new TNode(data);
                        currentNode.right = newNode;
                        added = true;
                    }
                    else
                    {
                        currentNode = currentNode.right;
                    }
                }
            } while (!added);

        }

        public void AddRecur(int value, TNode currentNode)
        {
            if (currentNode == null)
            {
                currentNode = new TNode(value);
                return;
            }
            else if (value < currentNode.data)
            {
                AddRecur(value, currentNode.left);
            }
            else
            {
                AddRecur(value, currentNode.right);
            }
        }

        public void test(TNode n)
        {
            n.data = 10;
        }

        public void print()
        {
            if (this.top != null)
            {
                Console.Write(top.data + " ");
                //print
            }

        }
    }

    public class TNode
    {
        public int data;
        public TNode left;
        public TNode right;

        public TNode(int data)
        {
            this.data = data;
            left = null;
            right = null;
        }
    }
}
