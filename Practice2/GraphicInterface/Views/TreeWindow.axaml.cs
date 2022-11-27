using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Interactivity;
using GraphicInterface.ViewModels;
using System;

namespace GraphicInterface.Views
{
    public partial class TreeWindow : Window
    {
        TreeWindowViewModel vM = new();

        int newNode = 0;
        string searchedNode = "";
        string father = "";
        string position = "";

        public TreeWindow()
        {
            InitializeComponent();
            NodeInsertion.Items = vM.Nodes();
            positionSelection.Items = vM.positionsCB();
        }

        public void searching(object sender, RoutedEventArgs e)
        {
            if (SearchB.SelectedItem != null)
            {
                searchedNode = (string)SearchB.SelectedItem;
                Road.Text = vM.searching(Int32.Parse(searchedNode));
            }
        }



        public void insertion(object sender, RoutedEventArgs e)
        {
            if (newNodeData.Text == null)
            {
                return;
            }
            newNode = Int32.Parse(newNodeData.Text);
            if (NodeInsertion.SelectedItem != null)
            {
                father = (string)NodeInsertion.SelectedItem;
            }
            else
            {
                father = "Defaul";
            }
            if (positionSelection.SelectedItem != null)
            {
                position = (string)positionSelection.SelectedItem;
            }
            else
            {
                position = "Defaul";
            }
            vM.insertion(newNode, father, position);
            NodeInsertion.Items = null;
            SearchB.Items = null;
            update(sender, e);
        }

        public void treeStructurePrint(object sender, RoutedEventArgs e)
        {
            treeStructure.Text = vM.treeStructurePrint();
        }

        public void In_OrderTraverse(object sender, RoutedEventArgs e)
        {
            In_OrderTraversing.Text = vM.In_OrderTraverse();
        }

        public void Post_OrderTraverse(object sender, RoutedEventArgs e)
        {
            Post_OrderTraversing.Text = vM.Post_OrderTraverse();
        }

        public void Pre_OrderTraverse(object sender, RoutedEventArgs e)
        {
            Pre_OrderTraversing.Text = vM.Pre_OrderTraverse();
        }

        public void levelPrint(object sender, RoutedEventArgs e)
        {
            LevelCounter.Text = vM.levels();
        }

        public void NodesInsertin(object sender, RoutedEventArgs e)
        {
            SearchB.Items = vM.Nodes();
            NodeInsertion.Items = vM.Nodes();
        }

        public void update(object sender, RoutedEventArgs e)
        {
            treeStructurePrint(sender, e);
            In_OrderTraverse(sender, e);
            Post_OrderTraverse(sender, e);
            Pre_OrderTraverse(sender, e);
            levelPrint(sender, e);
            NodesInsertin(sender, e);
        }

        public void windowGraph(object sender, RoutedEventArgs e)
        {
            MainWindow mW = new();
            mW.Show();
            this.Close();
        }
    }
}
