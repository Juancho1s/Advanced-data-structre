using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using trees_123_;

namespace GraphicInterface.ViewModels
{
    internal class TreeWindowViewModel : ViewModelBase
    {
        MethodsTree mT = new();

        List<string> nodesCB = new();
        List<string> positionsL = new();

        public List<string> Nodes()
        {
            nodesCB.Clear();
            nodesCB.Add("Defaul");
            foreach (int i in mT.nodesList)
            {
                nodesCB.Add(i.ToString());
            }
            return nodesCB;
        }

        public List<string> positionsCB()
        {
            positionsL.Add("Defaul");
            positionsL.Add("Left");
            positionsL.Add("Right");
            return positionsL;
        }

        public void insertion(int newNode, string father, string position)
        {
            if (mT.root[0] == null)
            {
                mT.rootInsertion(newNode);
                return;
            }
            if (father.Equals("Defaul"))
            {
                mT.insertNewNode(mT.root[0], new NodeTree(newNode));
                return;
            }
            if (position.Equals("Defaul"))
            {
                mT.insertNewNode(mT.root[0], new NodeTree(newNode), Int32.Parse(father));
                return;
            }
            mT.insertNewNode(mT.root[0], new NodeTree(newNode), position, Int32.Parse(father));
        }

        public string In_OrderTraverse()
        {
            return mT.traverseIn_Order(mT.root[0]);
        }

        public string Post_OrderTraverse()
        {
            return mT.traversePost_Order(mT.root[0]);
        }

        public string Pre_OrderTraverse()
        {
            return mT.traversePre_Order(mT.root[0]);
        }

        public List<int> itemsCB()
        {
            return mT.nodesList;
        }

        public string treeStructurePrint()
        {
            if (mT.root[0] == null)
            {
                return "";
            }
            return mT.getTreeStructure(mT.root[0]);
        }


    }
}
