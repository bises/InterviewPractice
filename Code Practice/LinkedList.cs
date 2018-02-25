using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
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
            if(headNode == null)
            {
                return;
            }
            SingleLinkNode prev = null;
            SingleLinkNode current = headNode;
            SingleLinkNode next = current.next;
            while(next != null)
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
            if(headNode == null)
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
}
