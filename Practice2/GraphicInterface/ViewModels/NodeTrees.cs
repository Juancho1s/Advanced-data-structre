using DynamicData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicInterface.ViewModels
{
    internal class NodeTrees
    {
        /*Properties*/
        internal int data { get; set; }
        internal int rootData { get; set; }
        internal int leftRight { get; set; }
        internal NodeTrees? rootNode { get; set; }
        internal NodeTrees? leftNode { get; set; }
        internal NodeTrees? rightNode { get; set; }
        //////////////////////


        /*Constructor*/
        public NodeTrees(int data)
        {
            this.data = data;
        }
        //////////////////////
    }
}
