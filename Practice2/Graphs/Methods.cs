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
        public List<Node> lists = new List<Node>();

        //////////      

        //////////// Creation of lists



        //////////


        ////////// Add node to the graph and create lists

        public void addToTheGraph(int newNode, int nodeConection)
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
