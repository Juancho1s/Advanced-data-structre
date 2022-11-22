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
            nodesList.Content = m.assigningNodeList(newNodeData);
            insertMatrix();
        }

        private void insertMatrix()
        {
            adjasenciMatrix.Text = m.assigningMatrix();
        }
    }
}
