using System;
using System.Security.Cryptography.X509Certificates;

namespace trees_123_
{
    internal class Node
    {

        private int data { get; set; }
        private int rootNode { get; set; }
        private Node? leftNode { get; set; }
        private Node? rightNode { get; set; }
        private bool x = false;

        public Node(int data)
        {
            this.data = data;
        }
        
        public bool checking(Node tree)
        {

            if (x == true) 
            {                
                return x = true;
            }
            if (tree.rightNode == null)
            {
                if (tree.leftNode == null)
                {
                    return x ;
                }                
            }
            else
            {
                if (tree.leftNode != null)
                {
                    x = checking(tree.leftNode);
                }                
            }
            
        }

        public void addNode(Node newNode)
        {
            this.leftNode = newNode;

            if (newNode.Equals(data))
            {
                Console.WriteLine("This node is already in the list.");
                return;
            }
            if (leftNode == null)
            {
                leftNode = newNode;
                newNode.rootNode = rootNode;
            }
            else if (rightNode == null)
            {
                rightNode = newNode;
                newNode.rootNode = rootNode;
            }
            else if (leftNode != null)
            {
                if (leftNode.leftNode == null)
                {
                    leftNode.addNode(newNode);
                }
                else if (leftNode.rightNode == null)
                {
                    leftNode.addNode(newNode);
                }
                else if (rightNode != null)
                {
                    if (leftNode != null)
                    {
                        if (rightNode.leftNode == null)
                        {
                            rightNode.addNode(newNode);
                        }
                        else if (rightNode.rightNode == null)
                        {
                            rightNode.addNode(newNode);
                        }
                        else
                        {
                            insert(newNode);
                        }
                    }
                }
            }

        }
        private void insert(Node newNode)
        {
            if (leftNode == null)
            {
                leftNode = newNode;
            }
            else
            {
                leftNode.insert(newNode);
            }
        }

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
            this.rootNode = rootNode;
        }
        public int getRootNode()
        {
            return this.rootNode;
        }
    }
}
