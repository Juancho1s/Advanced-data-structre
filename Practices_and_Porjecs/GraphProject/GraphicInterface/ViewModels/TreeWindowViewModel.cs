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
            if (mT.root[0] == null)
            {
                mT.nodesList.Clear();
                return nodesCB;
            }
            foreach (int i in mT.nodesList)
            {
                nodesCB.Add(i.ToString());
            }
            return nodesCB;
        }

        public void deleteNode(int nodeSpesified)
        {
            mT.delete(mT.root[0], nodeSpesified);

        }

        public string searching(int searchedNode)
        {
            return mT.searchNode(mT.root[0], searchedNode);
        }

        public void eraseRoot()
        {
            mT.root[0] = null;
        }

        public string levels()
        {
            if (mT.root[0] == null)
            {
                return "";
            }
            return mT.levelCounter(mT.root[0]).ToString();
        }

        public List<string> positionsCB()
        {
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
            if (mT.root[0] == null)
            {
                return "";
            }
            return mT.traverseIn_Order(mT.root[0]);
        }

        public string Post_OrderTraverse()
        {
            if (mT.root[0] == null)
            {
                return "";
            }
            return mT.traversePost_Order(mT.root[0]);
        }

        public string Pre_OrderTraverse()
        {
            if (mT.root[0] == null)
            {
                return "";
            }
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
