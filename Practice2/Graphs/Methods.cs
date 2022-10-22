using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    internal class Methods
    {

        ////////// Atributes        

        public List<Node> nodesList = new List<Node>();
        public List<List<Node>> lists = new List<List<Node>>();
        public List<int[]> edges = new List<int[]>();

        //////////      



        //////////// Creation of lists



        //////////



        ////////// Add node to the graph and create lists

        public void addToTheGraphDirection(int newNode, int nodeConection, int weight)
        {
            foreach (Node node_1 in g.nodesList)
            {
                if (nodeConection == node_1.data)
                {
                    if (validation(node_1, newNode) == true)
                    {
                        Console.WriteLine("The new node is already in the conections of the Node");
                        return;
                    }
                    foreach (Node node_2 in g.nodesList)
                    {
                        if (newNode == node_2.data)
                        {
                            node_1.nodesConectios.Add(node_2);
                            g.edges.Add(new int[] { node_1.data, node_2.data, weight });
                        }
                    }
                    Console.WriteLine("The new Node was never found in the nodes list.");
                    return;
                }                
            }
        }

        private bool validation(Node node, int vCheck)
        {
            bool x = false;
            foreach (Node nCheck in node.nodesConectios)
            {
                if (nCheck.data == vCheck)
                {
                    return x = true;
                }
            }
            return x;
        }

        //////////



        ////////// Create Node

        public void createNode(int data)
        {
            foreach (Node Node in g.nodesList)
            {
                if (data == Node.data)
                {
                    Console.WriteLine("The node is already in the Nodes list (they cannot be repeated).");
                    return;
                }
            }
            nodesList.Add(new Node(data));
        }

        //////////
    }
}
