using System;
using System.Security.Cryptography.X509Certificates;

namespace trees_123_
{
    internal class Node
    {

        internal int data { get; set; }
        internal int rootData { get; set; }
        internal Node? leftNode { get; set; }
        internal Node? rightNode { get; set; }

        /*Constructor*/
        public Node(int data)
        {
            this.data = data;
        }
        //////////////////////

        /*Methods*/

        ////////////////////// 

        /*Getters and setters*/
        public void setLeftNode(Node newNode)
        {
            this.leftNode = newNode;
        }
        public Node? getLeftNode()
        {
            return this.leftNode;
        }

        public void setRightNode(Node newNode)
        {
            this.rightNode = newNode;
        }
        public Node? getRightNode()
        {
            return this.rightNode;
        }

        public void setRootNode(int rootNode)
        {
            this.rootData = rootNode;
        }
        public int getRootNode()
        {
            return this.rootData;
        }

        public int getData()
        {
            return this.data;
        }
        //////////////////////
    }
}
