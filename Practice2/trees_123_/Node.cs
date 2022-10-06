using System;
using System.Security.Cryptography.X509Certificates;

namespace trees_123_
{
    internal class Node
    {

        private int data { get; set; }
        private int rootData { get; set; }
        private Node? leftNode { get; set; }
        private Node? rightNode { get; set; }
        private bool x = false;

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
                    this.x = true;
                    return;
                }
                else if (tree.rightNode == null & refToLR == 1)
                {
                    tree.rightNode = newNode;
                    this.x = true;
                    return;
                }                
                Console.WriteLine("The father already has a child in the position spesified.");                
            }
            else
            {
                if (this.x == true)
                {
                    return;
                }
                if (tree.leftNode != null)
                {
                    insertNewNode(tree.leftNode, newNode, refToFather);
                }
                if (tree.rightNode != null)
                {
                    insertNewNode(tree.rightNode, newNode, refToFather);
                }
            }
            Console.WriteLine("The node spesified as father was not found.");
        }

        public void insertNewNode(Node tree, Node newNode, int refToFather)
        {
            if (tree.data == refToFather)
            {
                if (tree.leftNode == null)
                {
                    tree.leftNode = newNode;
                    this.x = true;
                    return;
                }
                else if (tree.rightNode == null)
                {
                    tree.rightNode = newNode;
                    this.x = true;
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
                if (this.x == true)
                {
                    return;
                }
                if (tree.leftNode != null )
                {
                    insertNewNode(tree.leftNode, newNode, refToFather);
                }
                if (tree.rightNode != null)
                {
                    insertNewNode(tree.rightNode, newNode, refToFather);
                }
            }
            Console.WriteLine("The node spesified as father was not found.");
        }

        public void insertNewNode(Node tree, Node newNode)
        {
            if (tree.leftNode != null)
            {
                insertNewNode(tree.leftNode, newNode);
            }
            else
            {
                tree.leftNode = newNode;
            }
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
        //////////////////////
    }
}
