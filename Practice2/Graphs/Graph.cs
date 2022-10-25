using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    internal class Graph
    {
        //////////Atributes

        internal List<Node> nodesList = new List<Node>();
        internal List<Edges> edges = new List<Edges>();        

        //////////      



        //////////Getters and setters

        public List<Node> getNodesList()
        {
            return nodesList;
        }

        public List<Edges> getEdges()
        {
            return edges;
        }

        //////////
    }
}
