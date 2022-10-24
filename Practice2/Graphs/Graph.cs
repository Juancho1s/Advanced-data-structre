using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    internal class Graph
    {
        //////////

        internal List<Node> nodesList = new List<Node>();
        internal List<int[]> edges = new List<int[]>();

        public List<Node> getNodesList()
        {
            return nodesList;
        }

        public List<int[]> getEdges()
        {
            return edges;
        }
    }
}
