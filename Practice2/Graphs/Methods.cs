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

        public float[,] matrixCreation()
        {
            string print = "  ";

            float[,] matrix = new float[g.nodesList.Count, g.nodesList.Count];
            for (int i = 0; i < g.nodesList.Count; i++)
            {
                print += "  " + (i + 1);
            }
            print += "\n\n1   ";
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (j != i)
                    {
                        foreach (Node checking in g.nodesList[i].nodesConectios)
                        {
                            if (checking.data == g.nodesList[j].data)
                            {
                                matrix[i, j] = g.edges[index(g.edges, g.nodesList[i].data, g.nodesList[j].data)].weight;
                                break;
                            }
                        }
                        print += matrix[i, j] + "  ";
                    }
                    else
                    {
                        print += matrix[i, j] + "  ";
                    }

                }
                if (i < matrix.GetLength(0) - 1)
                {
                    print += "\n" + (i + 2) + "   ";
                }
            }
            Console.WriteLine(print);
            return matrix;
        }

        private int index(List<Edges> list, int startNode, int finalNode)
        {
            int i = 0;
            for (i = 0; i < list.Count; i++)
            {
                if (list[i].startNode == startNode & list[i].finalNode == finalNode)
                {
                    return i;
                }
            }
            return i;
        }

        //////////



        ////////// Add edge to the graph

        public void addEdge(int newNode, int nodeConection, float weight)
        {
            if (g.nodesList.Count == 0)
            {
                return;
            }
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
                            g.edges.Add(new Edges(nodeConection, newNode));
                            g.edges[g.edges.Count - 1].setWeight(weight);
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
            if (g.nodesList.Count == 0)
            {
                return;
            }
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

        //////////Traversings

        public void Traversing_DFS(int node)
        {
            List
            int index = 0;
            for (index = 0; index < g.nodesList.Count; index++)
            {
                if (g.nodesList[index].data == node)
                {
                    break;
                }
            }
            recursiveTraversingDFS(g.nodesList[index]);
        }

        private void recursiveTraversingDFS(Node node)
        {

        }
        //////////
    }
}
