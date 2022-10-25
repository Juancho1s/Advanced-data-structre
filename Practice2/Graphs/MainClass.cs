using Graphs;

internal class MainClass
{
    private static void Main(string[] args)
    {
        Methods methods = new Methods();

        methods.createNode(1);
        methods.createNode(2);
        methods.createNode(3);
        methods.createNode(4);
        methods.createNode(5);
        methods.createNode(6);
        methods.createNode(7);
        methods.createNode(8);
        methods.createNode(9);
        methods.createNode(10);
        methods.createNode(11);
        methods.createNode(12);

        methods.addEdge(1, 3, 1);
        methods.addEdge(1, 4, 2);
        methods.addEdge(4, 3, 3);
        methods.addEdge(3, 5, 4);
        methods.addEdge(3, 6, 5);
        methods.addEdge(3, 2, 6);
        methods.addEdge(2, 6, 7);
        methods.addEdge(5, 10, 8);
        methods.addEdge(10, 9, 9);
        methods.addEdge(9, 6, 10);
        methods.addEdge(6, 7, 11);
        methods.addEdge(7, 8, 12);

        methods.deleteNode(12);
        methods.deleteEdge(6, 9);


    }
}