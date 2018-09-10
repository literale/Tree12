using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree1
{
    class MyTour
    {
        Node[] array;
        public Node Competition(ref Node ph)
        {
            if (ph.left != null)
            {
                if (ph.left.data == ph.data)
                    ph.left = Competition(ref ph.left);
                else
                    ph.right = Competition(ref ph.right);

            }
            else
            {
                if (ph.right != null)
                    ph.right = Competition(ref ph.right);
            }
            if ((ph.left == null) && (ph.right == null))
                ph = null;
            else
            {
                if ((ph.left == null) || ((ph.right == null) && (Convert.ToInt32(ph.left.data) > Convert.ToInt32(ph.right.data))))
                    ph.data = ph.right.data;
                else
                    ph.data = ph.left.data;
                return ph;
            }
            return ph;
        }
    }
}
