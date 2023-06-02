using System;
using System.Collections.Generic;
using System.Text;

namespace GraphicInterface.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        MethodsGraph mG = new();

        public string assigningNodeList(int newNode)
        {
            mG.createNode(newNode);
            return showNodesL();
        }


        public string showNodesL()
        {
            return mG.showNodesList();
        }

        public string assigningMatrix()
        {
            return mG.matrixCreation();
        }

        public string assigningDFS_Traversing(int startNode)
        {
            return mG.traversing_DFS(startNode);
        }

        public string assigningBFS_Traversing(int startNode)
        {
            return mG.traversing_BFS(startNode);
        }

        public string assigningTheSortestRoad(int startNode, int finalNode)
        {
            return mG.theShortestPath(startNode, finalNode);
        }

        public string theShortestRoad(int startNode, int lastNdoe)
        {
            return mG.theShortestPath(startNode, lastNdoe);
        }

        public string theLongestPath(int startNode, int lastNode)
        {
            return mG.theLongestPath(startNode, lastNode);
        }

        public string getWeightL()
        {
            string aux = mG.getWeightL() + "";
            mG.setWeightL(0);
            return aux;
        }

        public string getWeight()
        {
            string aux = mG.getWeight() + "";
            mG.setWeight(0);
            return aux;
        }

        public void resetAll()
        {
            mG.resetAll();
        }

        public void deleteNode(int dNode)
        {
            mG.deleteNode(dNode);
        }

        public void edgeInsertion(int startNode, int finalNode, float weight)
        {
            mG.addEdge(finalNode, startNode, weight);
        }

        public void deleteEdge(int startNode, int fialNode)
        {
            mG.deleteEdge(startNode, fialNode);
        }
    }
}
