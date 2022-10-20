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
            foreach (Node node in nodesList)
            {
                if (node.data == nodeConection)
                {
                    for (int i = 0; i < nodesList.Count; i++)
                    {
                        if (nodesList[i].data == newNode)
                        {
                            for (int j = 0; j < nodesList[i].nodesConectios.Count; j++)
                            {
                                if (nodesList[i].nodesConectios[j].data)
                                {

                                }
                            }
                            node.nodesConectios.Add();
                            edges.Add(new int[] { nodeConection, newNode, weight });
                            return;
                        }
                    }                    
                }
            }
        }

        public void addToTheGraphNoDirection(int newNode, int nodeConection, int weight)
        {
            foreach (Node node in nodesList)
            {
                if (node.data == nodeConection)
                {
                    foreach (Node search in nodesList)
                    {
                        if (search.data == newNode)
                        {
                            node.nodesConectios.Add(search);
                            search.nodesConectios.Add(node);
                            edges.Add(new int[] { nodeConection, newNode, weight });
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
            foreach (Node Node in nodesList)
            {
                if (data == Node.data)
                {
                    Console.WriteLine("The node is already in the graph");
                    return;
                }
            }
            nodesList.Add(new Node(data));
        }

        //////////
    }
}
