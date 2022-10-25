using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Graphs
{
    internal class Methods
    {

        ////////// Atributes

        private Graph g = new Graph();

        //////////      



        //////////// Creation of Matrix

        public int[,] matrixCreation()
        {
            int aux = g.nodesList.Count - 1;
            int[,] matrix = new int[aux, aux];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {

                }
            }
            return matrix;
        }

        //////////



        ////////// Add edge to the graph

        public void addEdge(int newNode, int nodeConection, float weight)
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
                            g.edges.Add(new Edges(nodeConection, newNode, weight));
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

        public void deleteNode(int indicated)
        {
            if (g.edges.Count == 0)
            {
                return;
            }            
            foreach (Node cheking in g.nodesList)
            {
                if (cheking.data == indicated)
                {
                    g.nodesList.Remove(cheking);
                    break;
                }
            }
            foreach (Node checking_1 in g.nodesList)
            {
                if (checking_1.nodesConectios.Count != 0)
                {
                    foreach (Node checking_2 in checking_1.nodesConectios)
                    {
                        if (checking_2.data == indicated)
                        {
                            checking_1.nodesConectios.Remove(checking_2);
                            break;
                        }
                    }
                }
            }
        }

        //////////
        


        ////////// Delete edge

        public void deleteEdge(int startNode, int finalNode)
        {
            foreach (Edges checking in g.edges)
            {
                if (checking.startNode == startNode & checking.finalNode == finalNode)
                {
                    g.edges.Remove(checking);
                    break;
                }
            }
            foreach (Node checking_1 in g.nodesList)
            {
                if (checking_1.data == startNode)
                {
                    foreach (Node checking_2 in checking_1.nodesConectios)
                    {
                        if (checking_2.data == finalNode)
                        {
                            checking_1.nodesConectios.Remove(checking_2);
                            return;
                        }
                    }
                }
            }
            Console.WriteLine("The edge was never found");
        }
        
        //////////
    }
}
