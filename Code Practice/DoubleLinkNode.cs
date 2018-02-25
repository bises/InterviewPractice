using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class DoubleLinkNode
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
            if(next != null)
            {
                if(next.data == data)
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
}
