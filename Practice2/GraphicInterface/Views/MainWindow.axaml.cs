using Avalonia.Controls;
using Avalonia.Interactivity;
using GraphicInterface.ViewModels;
using Graphs;
using System;
using System.Runtime.InteropServices.ObjectiveC;

namespace GraphicInterface.Views
{
    public partial class MainWindow : Window
    {
        int newNodeData = 0;
        int sNode_1 = 0;
        int sNode_2 = 0;
        float weight = 0;

        //References to other calsses (Object)
        private MainWindowViewModel m = new MainWindowViewModel();

        public MainWindow()
        {
            InitializeComponent();
        }

        public void nodeInsertion(object sender, RoutedEventArgs e)
        {
            if (newNodeInput.Text == null)
            {
                return;
            }
            newNodeData = Int32.Parse(newNodeInput.Text);
            nodesList.Text = m.assigningNodeList(newNodeData);
            insertMatrix(sender, e);
            newNodeInput.Text = null;
        }

        private void insertMatrix(object sender, RoutedEventArgs e)
        {
            adjasenciMatrix.Text = m.assigningMatrix();
        }

        public void resetAll(object sender, RoutedEventArgs e)
        {
            m.resetAll();
            nodesList.Text = null;
            adjasenciMatrix.Text = null;
            indexStart.Text = null;
            dEdgeFinal.Text = null;
            dEdgeStart.Text = null;
            dNode.Text = null;
            indexFinal.Text = null;
            conectionWheight.Text = null;
            roadFinal.Text = null;
            roadStart.Text = null;
            theRoad.Text = null;
            weightTB.Text = null;
            DFS.Text = null;
            BFS.Text = null;
            InitialNodeBFS.Text = null;
            InitialNodeDFS.Text = null;
        }

        public void deleteNodeM(object sender, RoutedEventArgs e)
        {
            if (dNode.Text == null)
            {
                return;
            }
            sNode_1 = Int32.Parse(dNode.Text);
            m.deleteNode(sNode_1);
            nodesList.Text = m.showNodesL();
            insertMatrix(sender, e);
            theShortestPath(sender, e);
            DFS_Trigger(sender, e);
            BFS_Trigger(sender, e);
            dNode.Text = null;
        }

        public void edgeInsertion(object sender, RoutedEventArgs e)
        {
            if (conectionWheight.Text == null)
            {
                return;
            }
            if (indexFinal.Text == null)
            {
                return;
            }
            if (indexStart.Text == null) 
            { 
                return; 
            }
            sNode_1 = Int32.Parse(indexStart.Text);
            sNode_2 = Int32.Parse(indexFinal.Text);
            weight = Convert.ToSingle(conectionWheight.Text);
            m.edgeInsertion(sNode_1, sNode_2, weight);
            insertMatrix(sender, e);
            theShortestPath(sender, e);
            BFS_Trigger(sender, e);
            DFS_Trigger(sender, e);
            indexStart.Text = null;
            indexFinal.Text = null;
        }

        public void theShortestPath(object sender, RoutedEventArgs e)
        {
            if (roadStart.Text == null)
            {
                return;
            }
            if (roadFinal.Text == null)
            {
                return;
            }
            sNode_1 = Int32.Parse(roadStart.Text);
            sNode_2 = Int32.Parse(roadFinal.Text);
            theRoad.Text = m.theShortestRoad(sNode_1, sNode_2);
            weightTB.Text = "$" + m.getWeight();
        }

        public void BFS_Trigger(object sender, RoutedEventArgs e)
        {
            if (InitialNodeBFS.Text == null)
            {
                return;
            }
            sNode_1 = Int32.Parse(InitialNodeBFS.Text);
            BFS.Text = m.assigningBFS_Traversing(sNode_1);
        }

        public void DFS_Trigger(object sender, RoutedEventArgs e)
        {
            if (InitialNodeDFS.Text == null)
            {
                return;
            }
            sNode_1 = Int32.Parse(InitialNodeDFS.Text);
            DFS.Text = m.assigningDFS_Traversing(sNode_1);
        }

        public void deleteEdge(object sender, RoutedEventArgs e)
        {
            if (dEdgeFinal.Text == null)
            {
                return;
            }
            if (dEdgeStart.Text == null)
            {
                return;
            }
            sNode_1 = Int32.Parse(dEdgeStart.Text);
            sNode_2 = Int32.Parse(dEdgeFinal.Text);
            m.deleteEdge(sNode_1, sNode_2);
            insertMatrix(sender, e);
            theShortestPath(sender, e);
            DFS_Trigger(sender, e);
            BFS_Trigger(sender, e);
            dEdgeStart.Text = null;
            dEdgeFinal.Text = null;
        }
        public void buttonTree (object sendetr, RoutedEventArgs e)
        {
            TreeWindow t = new TreeWindow();
            t.Show();
            this.Close();


        }

    }
}
