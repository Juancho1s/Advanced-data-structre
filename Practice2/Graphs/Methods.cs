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

        //////////



        //////////Traversings

        public List<int> traversing_DFS(int node)
        {
            string DFS_Traversing = "";
            List<int> traversing = new List<int>();
            List<int> checking = new List<int>();
            int index = 0;
            for (index = 0; index < g.nodesList.Count; index++)
            {
                if (g.nodesList[index].data == node)
                {
                    break;
                }
            }
            recursiveTraversingDFS(g.nodesList[index], traversing, checking);
            Console.WriteLine("DFS_Traversing");
            foreach (int i in traversing)
            {
                DFS_Traversing += i + "  ";
            }
            Console.WriteLine(DFS_Traversing);
            return traversing;
        }

        private void recursiveTraversingDFS(Node node, List<int> traverse, List<int> checking)
        {
            traverse.Add(node.data);
            checking.Add(node.data);
            foreach (Node checking_1 in node.nodesConectios)
            {
                if (checkingBool(checking_1.data, checking) == false)
                {
                    recursiveTraversingDFS(checking_1, traverse, checking);
                }
            }
        }

        public List<int> traversing_BFS(int node)
        {
            string BFS_Traversing = "";
            List<int> traversing = new List<int>();
            List<int> auxTraversing = new List<int>();
            List<Node> checking = new List<Node>();
            int index = 0;
            for (index = 0; index < g.nodesList.Count; index++)
            {
                if (g.nodesList[index].data == node)
                {
                    checking.Add(g.nodesList[index]);
                    traversing.Add(g.nodesList[index].data);
                    auxTraversing.Add(g.nodesList[index].data);
                    break;
                }
            }
            BFS_Method(g.nodesList[index], traversing, auxTraversing, checking);
            Console.WriteLine("BFS_Traversing");
            foreach (int i in traversing)
            {
                BFS_Traversing += i + "  ";
            }
            Console.WriteLine(BFS_Traversing);
            return traversing;
        }

        private void BFS_Method(Node node, List<int> traverse, List<int> auxTraversing, List<Node> checking)
        {
            foreach (Node checking_1 in node.nodesConectios)
            {
                if (checkingBool(checking_1.data, auxTraversing) == false)
                {
                    traverse.Add(checking_1.data);
                    auxTraversing.Add(checking_1.data);
                    checking.Add(checking_1);
                }
            }
            checking.RemoveAt(0);
            if (checking.Count == 0)
            {
                return;
            }
            BFS_Method(checking[0], traverse, auxTraversing, checking);
        }

        //////////



        //////////The shortest road to the end

        public List<int> theShortestLeaf(int node)
        {
            string printRoad = "";
            List<int> road = new List<int>();
            List<int> auxTraversing = new List<int>();
            List<int> auxRoad = new List<int>();
            int index = 0;
            for (index = 0; index < g.nodesList.Count; index++)
            {
                if (g.nodesList[index].data == node)
                {
                    break;
                }
            }
            scout(g.nodesList[index], road, auxTraversing, auxRoad);
            foreach (int i in road)
            {
                printRoad += i + "  ";
            }
            Console.WriteLine("The shortest road to one leafis: " + printRoad);
            return road;
        }

        private void scout(Node node, List<int> road, List<int> auxTraversing, List<int> auxRoad)
        {
            bool x = false;
            auxRoad.Add(node.data);
            auxTraversing.Add(node.data);
            if (auxRoad.Count > road.Count & road.Count > 0)
            {
                auxRoad.RemoveAt(auxRoad.Count - 1);
                return;
            }
            foreach (Node checking_1 in node.nodesConectios)
            {
                if (checkingBool(checking_1.data, auxTraversing) == false)
                {
                    x = true;
                    scout(checking_1, road, auxTraversing, auxRoad);
                }
            }
            if (x != true)
            {
                if (road.Count != 0)
                {
                    road.Clear();
                    foreach (int i in auxRoad)
                    {
                        road.Add(i);
                    }
                }
                else
                {
                    foreach (int i in auxRoad)
                    {
                        road.Add(i);
                    }
                }
            }
            auxRoad.RemoveAt(auxRoad.Count - 1);
        }
        
        //////////



        //////////Binary search

        private bool checkingBool(int wanted, List<int> checking)
        {
            int lIndex = 0;
            int rIndex = checking.Count - 1;
            checking.Sort();
            while (lIndex <= rIndex)
            {
                int aux = (lIndex + rIndex) / 2;
                if (checking[aux] == wanted)
                {
                    return true;
                }
                else if (checking[aux] < wanted)
                {
                    lIndex = aux + 1;
                }
                else
                {
                    rIndex = aux - 1;
                }
            }
            return false;
        }

        //////////       
    }
}
