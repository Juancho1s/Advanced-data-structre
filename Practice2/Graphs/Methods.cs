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

        private Graph g = new Graph();

        //////////      

        //////////// Creation of lists



        //////////


        ////////// Add node to the graph and create lists

        public void addToTheGraphDirection(int newNode, int nodeConection, int weight)
        {
            foreach (Node node in g.nodesList)
            {
                if (node.data == nodeConection)
                {
                    foreach(Node search in g.nodesList)
                    {
                        if (search.data == newNode)
                        {
                            for (int j = 0; j < search.nodesConectios.Count; j++)
                            {
                                if (search.nodesConectios[j].data == nodeConection)
                                {
                                    Console.WriteLine("This conection cannot be made in this vertex.");
                                    return;
                                }
                            }
                            node.nodesConectios.Add(search);
                            g.edges.Add(new int[] { nodeConection, newNode, weight });
                            return;
                        }
                    }                    
                }
            }
        }

        public void addToTheGraphNoDirection(int newNode, int nodeConection, int weight)
        {
            foreach (Node node in g.nodesList)
            {
                if (node.data == nodeConection)
                {
                    foreach (Node search in g.nodesList)
                    {
                        if (search.data == newNode)
                        {
                            for (int j = 0; j < search.nodesConectios.Count; j++)
                            {
                                if (search.nodesConectios[j].data == nodeConection)
                                {
                                    Console.WriteLine("This conection cannot be made in this vertex.");
                                    return;
                                }
                            }
                            node.nodesConectios.Add(search);
                            search.nodesConectios.Add(node);
                            g.edges.Add(new int[] { nodeConection, newNode, weight });
                            return;
                        }
                    }
                }
            }
        }
        //////////


        ////////// Delete conection

        public void DeleteConection(int dNode, int fNode)
        {
            foreach (Node node in g.nodesList)
            {
                if (node.data == fNode)
                {
                    for(int i = 0; i < node.nodesConectios.Count; i++)
                    {
                        if (node.nodesConectios[i].data == dNode)
                        {
                            node.nodesConectios.RemoveAt(i);
                            for (int j = 0; j < g.edges.Count; j++)
                            {
                                if (g.edges[j][1] == fNode & g.edges[j][2] == dNode)
                                {
                                    g.edges.RemoveAt(j);
                                }
                            }
                            return;
                        }
                    }
                }
            }
        }

        //////////


        ////////// Create Node

        public void createNode(int data)
        {
            foreach (Node Node in g.nodesList)
            {
                if (data == Node.data)
                {
                    Console.WriteLine("The node is already in the graph");
                    return;
                }
            }
            g.nodesList.Add(new Node(data));
        }

        //////////
    }
}
