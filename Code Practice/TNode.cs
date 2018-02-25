using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
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
