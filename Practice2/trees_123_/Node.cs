using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trees_123_
{
    internal class Node
    {

        public int data { get; set; }
        public int rootNode { get; set; }
        public Node? leftNode { get; set; }
        public Node? rightNode { get; set; }

        public Node(int data)
        {
            this.data = data;
        }        

        public void addNode(Node newNode)
        {
            if (newNode.Equals(this.data))
            {
                Console.WriteLine("This node is already in the list.");
                return;
            }
            if (this.leftNode == null )
            {
                this.leftNode = newNode;
                newNode.setRootNode(rootNode);
            }else
            {
                this.rightNode = newNode;
                newNode.setRootNode(rootNode);
            }
        }

        public void setLeftNode(Node newNode)
        {
            this.leftNode = newNode;
        }

        public void setRightNode(Node newNode)
        {
            this.rightNode = newNode;
        }

        public void setRootNode(int rootNode)
        {
            this.rootNode = rootNode;
        }
    }
}
