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
