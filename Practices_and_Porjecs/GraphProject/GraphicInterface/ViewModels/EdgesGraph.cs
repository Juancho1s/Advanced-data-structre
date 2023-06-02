using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicInterface.ViewModels
{
    internal class EdgesGraph
    {
        ///////////Atributes

        internal int startNode;
        internal int finalNode;
        internal float weight;

        //////////



        //////////Constructor

        internal EdgesGraph(int startNode, int finalNode)
        {
            this.startNode = startNode;
            this.finalNode = finalNode;
        }

        //////////



        //////////Getters and setters

        internal void setWeight(float weight)
        {
            this.weight = weight;
        }

        //////////
    }
}
