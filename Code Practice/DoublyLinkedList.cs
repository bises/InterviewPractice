using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class DoublyLinkedList
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
            if(headNode == null)
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
            if(headNode == null)
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
            if(headNode == null)
            {
                Console.WriteLine("Empty List");
                return;
            }
            else if(headNode.data == data)
            {
                headNode.next.prev = null;
            }
            else if(tailNode.data == data)
            {
                tailNode.prev.next = null;
            }
            else
            {
                headNode.remove(data);
            }
            

        }
    }
}
