using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trees_123_
{    
    internal class Methods
    {
        private bool x = true;
        private int counter = 0;

        /*Mthods*/

        // Traverse
        public string traverseIn_Order(Node tree)
        {
            string ret = "";
            if (tree.leftNode != null)
            {
                ret += traverseIn_Order(tree.leftNode);
                
            }
            ret += tree.data + "   ";
            if (tree.rightNode != null)
            {                
                ret += traverseIn_Order(tree.rightNode);
            }
            return ret;
        }
        
        public string traversePre_Order(Node tree)
        {
            string ret = "";
            ret += tree.data + "   ";
            if (tree.leftNode != null)
            {
                ret += traversePre_Order(tree.leftNode);

            }            
            if (tree.rightNode != null)
            {
                ret += traversePre_Order(tree.rightNode);
            }
            return ret;
        }

        public string traversePost_Order(Node tree)
        {
            string ret = "";
            if (tree.leftNode != null)
            {
                ret += traversePost_Order(tree.leftNode);

            }
            if (tree.rightNode != null)
            {
                ret += traversePost_Order(tree.rightNode);
            }
            ret += tree.data + "   ";
            return ret;
        }
        ///////

        //insert
        public void insertNewNode(Node tree, Node newNode, int refLefthRight, int refToFather)
        {
            if (tree.data == refToFather)
            {
                if (tree.leftNode == null & refLefthRight == 0)
                {
                    tree.leftNode = newNode;
                    this.x = true;
                    return;
                }
                else if (tree.rightNode == null & refLefthRight == 1)
                {
                    tree.rightNode = newNode;
                    this.x = true;
                    return;
                }
                Console.WriteLine("The father already has a child in the position spesified.");
            }
            else if (tree.leftNode != null | tree.rightNode != null)
            {

                if (tree.leftNode != null)
                {
                    insertNewNode(tree.leftNode, newNode, refLefthRight, refToFather);
                }
                if (tree.rightNode != null)
                {
                    insertNewNode(tree.rightNode, newNode, refLefthRight, refToFather);
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
            else if (tree.leftNode != null | tree.rightNode != null)
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

        public void insertNewNode(Node tree, Node newNode)
        {
            if (tree.leftNode == null)
            {
                tree.leftNode = newNode;
                return;
            }
            else
            {
                insertNewNode(tree.leftNode, newNode);
            }
        }
        ///////

        /*Level counter*/

        public int levelCounter(Node tree)
        {
            int aux1 = 1;
            int aux2 = 1;
            int counter = 0;
            if (tree.leftNode != null | tree.rightNode != null)
            {
                if (tree.leftNode != null)
                {
                    aux1 += getlevels(tree.leftNode);
                }
                if (tree.rightNode != null)
                {
                    aux2 += getlevels(tree.rightNode);
                }                
            }
            if (tree.leftNode != null | tree.rightNode != null)
            {                
                counter += Math.Max(aux1, aux2);
            }
            return counter;
        }
        ///////

    }
}
