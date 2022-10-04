using System;

namespace trees_123_
{
    internal class Node
    {

        private int data { get; set; }
        private int rootNode { get; set; }
        private Node? leftNode { get; set; }
        private Node? rightNode { get; set; }

        public Node(int data)
        {
            this.data = data;
        }        

        public void addNode2(Node newNode)
        {
            if (newNode.Equals(data))
            {
                Console.WriteLine("This node is already in the list.");
                return;
            }
            if (leftNode == null)
            {
                leftNode = newNode;
                newNode.setRootNode(rootNode);
                return;
            }
            else if (rightNode == null)
            {
                rightNode = newNode;
                newNode.setRootNode(rootNode);
                return;
            }
            if (leftNode != null)
            {
                if (rightNode != null)
                {
                    leftNode.addNode2(newNode);
                    return;
                }
                

            }            
        }
        
        public void addNode(Node newNode)
        {
            if (newNode.Equals(data))
            {
                Console.WriteLine("This node is already in the list.");
                return;
            }
            if (leftNode == null )
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
