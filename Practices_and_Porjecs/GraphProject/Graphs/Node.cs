using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    internal class Node
    {
        /// Attributes
        internal int data;

        internal List<Node> nodesConectios = new List<Node>();


        /// Constructor
        internal Node(int data)
        {
            this.data = data;
        }

    }
}
