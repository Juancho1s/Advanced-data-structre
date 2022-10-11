using System;
namespace trees_123_
{
    internal class Node
    {
        /*Properties*/
        internal int data { get; set; }
        internal int rootData { get; set; }
        internal int leftRight { get; set; }
        internal Node? rootNode { get; set; }
        internal Node? leftNode { get; set; }
        internal Node? rightNode { get; set; }
        //////////////////////


        /*Constructor*/
        public Node(int data)
        {
            this.data = data;
        }
        //////////////////////
       

        /*Methods*/
        ////////////////////// 
        

        /*Getters and setters*/
        //////////////////////
    }
}
