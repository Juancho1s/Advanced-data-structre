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
    }
}
