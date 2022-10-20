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

        methods.addToTheGraph(1, 3);
        methods.addToTheGraph(1, 4);
        methods.addToTheGraph(4, 3);
        methods.addToTheGraph(3, 5);
        methods.addToTheGraph(3, 6);
        methods.addToTheGraph(3, 2);
        methods.addToTheGraph(2, 6);
        methods.addToTheGraph(5, 10);
        methods.addToTheGraph(10, 9);
        methods.addToTheGraph(9, 6);
        methods.addToTheGraph(6, 7);
        methods.addToTheGraph(7, 8);


    }
}