using Avalonia.Controls;
using Avalonia.Interactivity;
using GraphicInterface.ViewModels;
using System;

namespace GraphicInterface.Views
{
    public partial class TreeWindow : Window
    {
        TreeWindowViewModel vM = new();

        int newNode = 0;
        string father = "";
        string position = "";

        public TreeWindow()
        {
            InitializeComponent();
            NodeInsertion.Items = vM.Nodes();
            positionSelection.Items = vM.positionsCB();
            NodeInsertion.SelectedIndex = 0;
            positionSelection.SelectedIndex = 0;
        }

        public void insertion(object sender, RoutedEventArgs e)
        {
            newNode = Int32.Parse(newNodeData.Text);
            father = NodeInsertion.SelectedItem.ToString();
            position = positionSelection.SelectedItem.ToString();
            vM.insertion(newNode, father, position);
            treeStructurePrint(sender, e);
            In_OrderTraverse(sender, e);
            Post_OrderTraverse(sender, e);
            Pre_OrderTraverse(sender, e);
            NodeInsertion.Items = vM.Nodes();
            NodeInsertion.SelectedIndex = 0;
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

        public void windowGraph(object sender, RoutedEventArgs e)
        {
            MainWindow mW = new();
            mW.Show();
            this.Close();
        }
    }
}
