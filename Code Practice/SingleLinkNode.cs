using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
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
                if(current.data > max)
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
}
