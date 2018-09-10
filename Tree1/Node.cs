using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Tree1
{
  public  class Node
    {
        public object data =0;
        public Node left=null;
        public Node right=null;
        public int x;
        public int y;
        public bool visit;
        public Node next;
        public int count=0;

        public Node(Node left, Node right, object data, int x, int y)
        {
            this.left = left;
            this.right = right;
            this.data = data;
            this.x = x;
            this.y = y;
        }

    }
}
