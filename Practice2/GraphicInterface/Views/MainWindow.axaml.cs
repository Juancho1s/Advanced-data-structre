using Avalonia.Controls;
using Avalonia.Interactivity;
using GraphicInterface.ViewModels;
using Graphs;
using System;

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

        public TextBox GetNewNodeInput()
        {
            return newNodeInput;
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
        }

        public void deleteNodeM(object sender, RoutedEventArgs e)
        {
            sNode_1 = Int32.Parse(dNode.Text);
            m.deleteNode(sNode_1);
            nodesList.Text = m.showNodesL();
            adjasenciMatrix.Text = m.assigningMatrix();
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
            indexStart.Text = null;
            indexFinal.Text = null;
        }
    }
}
