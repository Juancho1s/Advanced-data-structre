using DynamicData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicInterface.ViewModels
{
    internal class MethodsGraph
    {

        ////////// Atributes

        private Graph g = new();
        private float weight = 0;

        //////////      

        
        ////////// Show the List of nodes

        public string showNodesList()
        {
            string returnList = "";
            foreach (NodesGraph i in g.nodesList)
            {
                returnList += i.data + "  ";
            }
            return returnList;
        }

        //////////
        
        
        ////////// Reset ALL
        
        public void resetAll ()
        {
            g.nodesList.Clear();
            g.edges.Clear();
        }
        
        //////////

        //////////// Creation of Matrix

        public string matrixCreation()
        {
            string print = "  ";
            if (g.nodesList.Count == 0)
            {
                return "";
            }
            float[,] matrix = new float[g.nodesList.Count, g.nodesList.Count];
            for (int i = 0; i < g.nodesList.Count; i++)
            {
                print += "  " + (g.nodesList[i].data);
            }
            print += $"\n\n{g.nodesList[0].data}   ";
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (j != i)
                    {
                        foreach (NodesGraph checking in g.nodesList[i].nodesConectios)
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
                    print += "\n" + (g.nodesList[i + 1].data) + "   ";
                }
            }
            return print;
        }

        private int index(List<EdgesGraph> list, int startNode, int finalNode)
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
            foreach (NodesGraph node_1 in g.nodesList)
            {
                if (nodeConection == node_1.data)
                {
                    if (validationBool(node_1, newNode) == true)
                    {
                        Console.WriteLine("The new node is already in the conections of the Node");
                        return;
                    }
                    foreach (NodesGraph node_2 in g.nodesList)
                    {
                        if (newNode == node_2.data)
                        {
                            node_1.nodesConectios.Add(node_2);
                            g.edges.Add(new EdgesGraph(nodeConection, newNode));
                            g.edges[g.edges.Count - 1].setWeight(weight);
                            return;
                        }
                    }
                    Console.WriteLine("The new Node was never found in the nodes list.");
                    return;
                }
            }
        }

        private bool validationBool(NodesGraph node, int vCheck)
        {
            bool x = false;
            foreach (NodesGraph nCheck in node.nodesConectios)
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

        public string createNode(int data)
        {
            foreach (NodesGraph Node in g.nodesList)
            {
                if (data == Node.data)
                {
                    Console.WriteLine("The node is already in the Nodes list (they cannot be repeated).");
                    return "The node is already in the Nodes list (they cannot be repeated).";
                }
            }
            g.nodesList.Add(new NodesGraph(data));
            return "The node was added to the list";
        }

        //////////



        ////////// Delete Node

        public void deleteNode(int indicated)
        {
            if (g.nodesList.Count == 0)
            {
                return;
            }
            foreach (NodesGraph cheking in g.nodesList)
            {
                if (cheking.data == indicated)
                {
                    g.nodesList.Remove(cheking);
                    break;
                }
            }
            foreach (NodesGraph checking_1 in g.nodesList)
            {
                if (checking_1.nodesConectios.Count != 0)
                {
                    foreach (NodesGraph checking_2 in checking_1.nodesConectios)
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
            foreach (EdgesGraph checking in g.edges)
            {
                if (checking.startNode == startNode & checking.finalNode == finalNode)
                {
                    g.edges.Remove(checking);
                    break;
                }
            }
            foreach (NodesGraph checking_1 in g.nodesList)
            {
                if (checking_1.data == startNode)
                {
                    foreach (NodesGraph checking_2 in checking_1.nodesConectios)
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

        public string traversing_DFS(int node)
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
            return DFS_Traversing;
        }

        private void recursiveTraversingDFS(NodesGraph node, List<int> traverse, List<int> checking)
        {
            traverse.Add(node.data);
            checking.Add(node.data);
            foreach (NodesGraph checking_1 in node.nodesConectios)
            {
                if (checkingBool(checking_1.data, checking) == false)
                {
                    recursiveTraversingDFS(checking_1, traverse, checking);
                }
            }
        }

        public string traversing_BFS(int node)
        {
            string BFS_Traversing = "";
            List<int> traversing = new List<int>();
            List<int> auxTraversing = new List<int>();
            List<NodesGraph> checking = new List<NodesGraph>();
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
            return BFS_Traversing;
        }

        private void BFS_Method(NodesGraph node, List<int> traverse, List<int> auxTraversing, List<NodesGraph> checking)
        {
            foreach (NodesGraph checking_1 in node.nodesConectios)
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



        //////////The shortest road to the specified node

        public string theShortestPath(int start_Node, int last_Node)
        {
            bool x_1 = false, x_2 = false;
            string printRoad = "";
            List<int> road = new List<int>();
            List<int> auxTraversing = new List<int>();
            List<NodesGraph> traversing = new List<NodesGraph>();
            float weight = 0, auxWeight = 0;
            int index = 0;
            for (index = 0; index < g.nodesList.Count; index++)
            {
                if (g.nodesList[index].data == start_Node)
                {
                    x_1 = true;
                    break;
                }
            }
            foreach (NodesGraph i in g.nodesList)
            {
                if (i.data == last_Node)
                {
                    x_2 = true;
                    break;
                }
            }
            if (x_1 == false | x_2 == false)
            {
                Console.WriteLine("One of the specified nodes by arguments was not found in the system.");
                return printRoad;
            }
            scout(g.nodesList[index], road, traversing, auxTraversing, weight, auxWeight, last_Node);
            foreach (int i in road)
            {
                printRoad += i + "  ";
            }
            return printRoad;
        }

        private void scout(NodesGraph node, List<int> road, List<NodesGraph> traversing, List<int> auxTraversing, float weight, float auxWeight, int last_Node)
        {
            float auxWeight_2 = 0;
            traversing.Add(node);
            auxTraversing.Add(node.data);
            if (road.Count <= traversing.Count & road.Count > 0)
            {
                traversing.RemoveAt(traversing.Count - 1);
                auxTraversing.Remove(node.data);
                return;
            }
            if (traversing.Count > 1)
            {
                auxWeight_2 = weight_search(traversing[traversing.Count - 2].data, node.data);
                auxWeight += auxWeight_2;
            }
            if (node.data == last_Node)
            {
                road.Clear();
                foreach (NodesGraph restructuring in traversing)
                {
                    road.Add(restructuring.data);
                }
                this.weight = auxWeight;
                traversing.RemoveAt(traversing.Count - 1);
                auxTraversing.Remove(node.data);
                return;
            }
            foreach (NodesGraph checking in node.nodesConectios)
            {
                if (checkingBool(checking.data, auxTraversing) == false)
                {
                    scout(checking, road, traversing, auxTraversing, weight, auxWeight, last_Node);
                }
            }
            auxWeight -= auxWeight_2;
            traversing.RemoveAt(traversing.Count - 1);
            auxTraversing.Remove(node.data);
        }

        //////////



        //////////Looking for weight

        private float weight_search(int startNode, int finalNode)
        {
            float aux = 0;
            foreach (EdgesGraph i in g.edges)
            {
                if (i.startNode == startNode & i.finalNode == finalNode)
                {
                    aux = i.weight;
                    break;
                }
            }
            return aux;
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
        

        ////////// Getters and setters
        
        public float getWeight()
        {
            return this.weight;
        }

        public void setWeight(float weight)
        {
            this.weight = weight;
        }
        
        //////////
    }
}
