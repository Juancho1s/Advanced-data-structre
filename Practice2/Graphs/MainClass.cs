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

        methods.addToTheGraphNoDirection(1, 3, 2);
        methods.addToTheGraphNoDirection(1, 4, 2);
        methods.addToTheGraphNoDirection(4, 3, 2);
        methods.addToTheGraphNoDirection(3, 5, 2);
        methods.addToTheGraphNoDirection(3, 6, 2);
        methods.addToTheGraphNoDirection(3, 2, 2);
        methods.addToTheGraphNoDirection(2, 6, 2);
        methods.addToTheGraphNoDirection(5, 10, 2);
        methods.addToTheGraphNoDirection(10, 9, 2);
        methods.addToTheGraphNoDirection(9, 6, 2);
        methods.addToTheGraphNoDirection(6, 7, 2);
        methods.addToTheGraphNoDirection(7, 8, 2);
        
        methods.DeleteConection(8, 7);

        methods.addToTheGraphNoDirection(7, 8, 2);

    }
}