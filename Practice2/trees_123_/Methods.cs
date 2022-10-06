using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trees_123_
{    
    internal class Methods
    {
        /*Mthods*/
        // Traverse
        public void traverseIn_Order(Node tree)
        {
            if (tree.leftNode != null)
            {
                traverseIn_Order(tree.leftNode);
                
            }
            Console.WriteLine(tree.getData());
            if (tree.rightNode != null)
            {
                if (tree.leftNode != null)
                {
                    traverseIn_Order(tree.leftNode);
                }
                traverseIn_Order(tree.rightNode);
            }


        }
    }
}
