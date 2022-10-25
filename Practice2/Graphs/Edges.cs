using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    internal class Edges
    {
        ///////////Atributes

        internal int startNode;
        internal int finalNode;
        internal float weight;

        //////////
        


        //////////Constructor
        
        internal Edges(int startNode, int finalNode, float weight)
        {
            this.startNode = startNode;
            this.finalNode = finalNode;
            this.weight = weight;
        }
        
        //////////
    }
}
