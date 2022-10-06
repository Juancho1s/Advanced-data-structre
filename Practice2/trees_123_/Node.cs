using System;
using System.Security.Cryptography.X509Certificates;

namespace trees_123_
{
    internal class Node
    {

        public int data { get; set; }
        public int rootData { get; set; }
        public Node? leftNode { get; set; }
        public Node? rightNode { get; set; }

        /*Constructor*/
        public Node(int data)
        {
            this.data = data;
        }
        //////////////////////

        /*Methods*/
        public void insertNewNode(Node tree, Node newNode, int refToLR, int refToFather)
        {
            if (tree.data == refToFather)
            {
                if (tree.leftNode == null & refToLR == 0)
                {
                    tree.leftNode = newNode;
                    
                    return;
                }
                else if (tree.rightNode == null & refToLR == 1)
                {
                    tree.rightNode = newNode;
                    
                    return;
                }                
                Console.WriteLine("The father already has a child in the position spesified.");                
            }
            else
            {
                
                if (tree.leftNode != null)
                {
                    insertNewNode(tree.leftNode, newNode, refToFather);
                }
                if (tree.rightNode != null)
                {
                    insertNewNode(tree.rightNode, newNode, refToFather);
                }
            }
        }

        public void insertNewNode(Node tree, Node newNode, int refToFather)
        {
            if (tree.data == refToFather)
            {
                if (tree.leftNode == null)
                {
                    tree.leftNode = newNode;
                    
                    return;
                }
                else if (tree.rightNode == null)
                {
                    tree.rightNode = newNode;
                    
                    return;
                }
                else
                {
                    Console.WriteLine("The father has all its children.");
                    return;
                }
            }
            else
            {
                
                if (tree.leftNode != null )
                {
                    insertNewNode(tree.leftNode, newNode, refToFather);
                }
                if (tree.rightNode != null)
                {
                    insertNewNode(tree.rightNode, newNode, refToFather);
                }
            }
            
        }

        public void insertNewNode(Node tree, Node newNode)
        {

        }
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
