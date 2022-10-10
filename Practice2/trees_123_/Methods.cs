using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace trees_123_
{    
    internal class Methods
    {
        /*Attributs*/
        private bool x = true;        
        ///////

        /*Methods*/

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
            insertNewNodeLooking(tree, newNode, refLefthRight, refToFather);
            if (this.x == true)
            {
                Console.WriteLine("The node specified as father was never found.");
            }
            this.x = true;
        }
        private void insertNewNodeLooking(Node tree, Node newNode, int refLefthRight, int refToFather)
        {
            if (this.x == false)
            {
                return;
            }
            if (newNode.data == tree.data)
            {
                this.x = false;
                Console.WriteLine("The node that you wanted to add is already in the tree (they cannot be repeated)");
                return;
            }
            if (tree.data == refToFather)
            {
                if (tree.leftNode == null & refLefthRight == 0)
                {
                    newNode.rootData = tree.data;
                    newNode.rootNode = tree;
                    newNode.leftRight = 0;
                    tree.leftNode = newNode;
                    this.x = false;
                    return;
                }
                else if (tree.rightNode == null & refLefthRight == 1)
                {
                    newNode.rootData = tree.data;
                    newNode.rootNode = tree;
                    newNode.leftRight = 1;
                    tree.rightNode = newNode;                    
                    this.x = false;
                    return;
                }
                this.x = false;
                Console.WriteLine("The father already has a child in the position spesified.");
            }
            else if (tree.leftNode != null | tree.rightNode != null)
            {
                if (tree.leftNode != null)
                {
                    insertNewNodeLooking(tree.leftNode, newNode, refLefthRight, refToFather);
                }
                if (tree.rightNode != null)
                {
                    insertNewNodeLooking(tree.rightNode, newNode, refLefthRight, refToFather);
                }
            }          
        }

        public void insertNewNode(Node tree, Node newNode, int refToFather)
        {
            insertNewNodeLooking(tree, newNode, refToFather);
            if (this.x == true)
            {
                Console.WriteLine("The node specified as father was never found.");
            }
            this.x = true;
        }
        private void insertNewNodeLooking(Node tree, Node newNode, int refToFather)
        {
            if (this.x == false)
            {
                return;
            }
            if (newNode.data == tree.data)
            {
                this.x = false;
                Console.WriteLine("The node that you wanted to add is already in the tree (they cannot be repeated)");
                return;
            }
            if (tree.data == refToFather)
            {
                if (tree.leftNode == null)
                {
                    newNode.rootData = tree.data;
                    newNode.rootNode = tree;
                    newNode.leftRight = 0;
                    tree.leftNode = newNode;
                    this.x = false;
                    return;
                }
                else if (tree.rightNode == null)
                {
                    newNode.rootData = tree.data;
                    newNode.rootNode = tree;
                    newNode.leftRight = 1;
                    tree.rightNode = newNode;
                    this.x = false;
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
                    insertNewNodeLooking(tree.leftNode, newNode, refToFather);
                }
                if (tree.rightNode != null)
                {
                    insertNewNodeLooking(tree.rightNode, newNode, refToFather);
                }
            }
        }

        public void insertNewNode(Node tree, Node newNode)
        {
            looking(tree, newNode);
            if (this.x == true)
            {
                adding(tree, newNode);
            }            
            this.x = true;
        }
        private void adding(Node tree, Node newNode)
        {
            if (tree.leftNode == null)
            {
                newNode.rootData = tree.data;
                newNode.rootNode = tree;
                newNode.leftRight = 0;
                tree.leftNode = newNode;
                this.x = false;
                return;
            }
            else
            {
                adding(tree.leftNode, newNode);
            }
        }
        private void looking(Node tree, Node newNode)
        {
            if (this.x == false)
            {
                return;
            }
            if (newNode.data == tree.data)
            {
                this.x = false;
                Console.WriteLine("The node that you wanted to add is already in the tree (they cannot be repeated)");
                return;
            }
            if (tree.leftNode != null | tree.rightNode != null)
            {

                if (tree.leftNode != null)
                {
                    looking(tree.leftNode, newNode);
                }
                if (tree.rightNode != null)
                {
                    looking(tree.rightNode, newNode);
                }
            }

        }
        ///////
        

        /*Level counter*/
        public int levelCounter(Node tree)
        {
            int aux1 = 0;
            int aux2 = 0;
            int counter = 1;
            if (tree.leftNode != null | tree.rightNode != null)
            {
                if (tree.leftNode != null)
                {
                    aux1 += levelCounter(tree.leftNode);
                }
                if (tree.rightNode != null)
                {
                    aux2 += levelCounter(tree.rightNode);
                }                
            }
            if (tree.leftNode != null | tree.rightNode != null)
            {                
                counter += Math.Max(aux1, aux2);
            }
            return counter;
        }
        ///////
        

        /*Delete*/
        public void delete(Node tree, int dNode)
        {            
            deleteLooking(tree, dNode);
            if (this.x == true)
            {
                Console.WriteLine("The node specified to delete was never found.");
            }
            this.x = true;
        }
        private void deleteLooking(Node tree, int dNode)
        {
            if (this.x == false)
            {
                return;
            }

            if (tree.leftNode != null)
            {
                if (tree.leftNode.data == dNode)
                {
                    tree.leftNode = null;
                    this.x = false;
                    return;
                }
                deleteLooking(tree.leftNode, dNode);
            }

            if (tree.rightNode != null)
            {
                if (tree.rightNode.data == dNode) 
                {
                    tree.rightNode = null;
                    this.x = false;
                    return;
                }
                deleteLooking(tree.rightNode, dNode);
            }            
        }
        ///////


        /*search and road*/
        public List<int> searchNode(Node tree, int data)
        {
            List<int> listReturn = new List<int>();
            listReturn = search(tree, data, listReturn);
            if (this.x == true)
            {
                Console.WriteLine("The node spesified to search was not found.");
                return listReturn;
            }
            this.x = true;
            return listReturn;
        }
        private List<int> search(Node tree, int data, List<int> listReturn)
        {
            if (this.x != false)
            {
                if (tree.data == data)
                {
                    this.x = false;
                    return listReturn = road(tree);
                }
                if (tree.leftNode != null | tree.rightNode != null)
                {
                    if (tree.leftNode != null)
                    {
                        listReturn = search(tree.leftNode, data, listReturn);
                    }
                    if (tree.rightNode != null)
                    {
                        listReturn = search(tree.rightNode, data, listReturn);
                    }
                }
            }
            return listReturn;
        }
        private List<int> road(Node node)
        {
            string message = "The road to the node is; ";
            List<int> listReturn = new List<int>();
            while (node.rootNode != null)
            {
                listReturn.Add(node.data);
                node = node.rootNode;
            }
            listReturn.Add(node.data);
            listReturn.Sort();
            foreach (int i in listReturn)
            {
                message += i + "   ";
            }
            Console.WriteLine(message);
            return listReturn;
        }
        ///////


        /*Print tree*/
        //This method uses the level counter method 
        public string getTreeStructure(Node tree)
        {
            int levels = levelCounter(tree);
            return assembling(tree, levels, levels);
        }
        private string assembling(Node tree, int levels, int aux)
        {
            string ret = "";            
            for (int i = aux; i < levels; i++)
            {
                ret += "-- ";
            }
            if (tree.rootNode == null)
            {
                ret += tree.data + " SNode" + "\n";
            }
            else if(tree.leftRight == 0)
            {
                ret += tree.data + " LNode" + "\n";
            }
            else if (tree.leftRight == 1)
            {
                ret += tree.data + " RNode" + "\n";
            }

            if (tree.leftNode != null)
            {
                ret += assembling(tree.leftNode, levels, aux - 1);                    
            }
            if(tree.rightNode != null)
            {
                ret += assembling(tree.rightNode, levels, aux - 1);
            }
            return ret;
        }
        ///////
                
        
        //////////////
    }
}
