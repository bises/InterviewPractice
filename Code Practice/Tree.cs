using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
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
            if(top == null)
            {
                top = new TNode(data);
            }
            TNode currentNode = top;
            bool added = false;
            do
            {
                if(data < currentNode.data)
                {
                    // go left
                    if(currentNode.left == null)
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

        public void AddRecur(int value,TNode currentNode)
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
            if(this.top != null)
            {
                Console.Write(top.data + " ");
                //print
            }
           
        }
    }
}
