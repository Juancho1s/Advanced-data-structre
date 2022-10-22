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

        methods.addToTheGraphDirection(1, 3, 1);
        methods.addToTheGraphDirection(1, 4, 2);
        methods.addToTheGraphDirection(4, 3, 3);
        methods.addToTheGraphDirection(3, 5, 4);
        methods.addToTheGraphDirection(3, 6, 5);
        methods.addToTheGraphDirection(3, 2, 6);
        methods.addToTheGraphDirection(2, 6, 7);
        methods.addToTheGraphDirection(5, 10, 8);
        methods.addToTheGraphDirection(10, 9, 9);
        methods.addToTheGraphDirection(9, 6, 10);
        methods.addToTheGraphDirection(6, 7, 11);
        methods.addToTheGraphDirection(7, 8, 12);


    }
}