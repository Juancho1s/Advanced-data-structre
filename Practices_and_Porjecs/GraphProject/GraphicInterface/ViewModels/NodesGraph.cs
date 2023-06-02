using DynamicData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicInterface.ViewModels
{
    internal class NodesGraph
    {
        /// Attributes
        internal int data;

        internal List<NodesGraph> nodesConectios = new List<NodesGraph>();


        /// Constructor
        internal NodesGraph(int data)
        {
            this.data = data;
        }
    }
}
