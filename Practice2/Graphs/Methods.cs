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

        internal Graph g = new Graph();

        //////////      



        //////////// Creation of lists



        //////////



        ////////// Add edge to the graph

        public void addEdge(int newNode, int nodeConection, int weight)
        {
            foreach (Node node_1 in g.nodesList)
            {
                if (nodeConection == node_1.data)
                {
                    if (validationBool(node_1, newNode) == true)
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
                            return;
                        }
                    }
                    Console.WriteLine("The new Node was never found in the nodes list.");
                    return;
                }                
            }
        }

        private bool validationBool(Node node, int vCheck)
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
            g.nodesList.Add(new Node(data));
        }

        //////////



        ////////// Delete Node

        public void deleteNode(int dNodeD)
        {
            foreach (Node dNode in g.nodesList)
            {
                if (dNode.data == dNodeD)
                {
                    foreach (Node node in g.nodesList)
                    {
                        node.nodesConectios.Remove(dNode);
                    }
                    g.nodesList.Remove(dNode);
                    foreach (int[] i in g.edges)
                    {
                        if (i[1] == dNodeD | i[2] == dNodeD)
                        {
                            g.edges.Remove(i);
                        }
                    }
                }
            }
        }
        
        //////////
    }
}
