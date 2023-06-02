using System;
namespace trees_123_
{
    internal class NodeTree
    {
        /*Properties*/
        internal int data { get; set; }
        internal int rootData { get; set; }
        internal int leftRight { get; set; }
        internal NodeTree? rootNode { get; set; }
        internal NodeTree? leftNode { get; set; }
        internal NodeTree? rightNode { get; set; }
        //////////////////////


        /*Constructor*/
        public NodeTree(int data)
        {
            this.data = data;
        }
        //////////////////////
    }
}
