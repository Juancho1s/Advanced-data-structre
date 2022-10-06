using trees_123_;

internal class MainClass
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, buddies");

        Node firstNode = new Node(1);
        Node secondNode = new Node(2);
        Node thirdNode = new Node(3);
        Node fourthNode = new Node(4);
        Node fifthNode = new Node(5);
        Node sixthhNode = new Node(6);
        Node seventhNode = new Node(7);
        Node eightNode = new Node(8);
        Node ninthNode = new Node(9);
        Node thenthNode = new Node(10);
        Node eleventhNode = new Node(11);

        firstNode.insertNewNode(firstNode, secondNode);
        firstNode.insertNewNode(firstNode, thirdNode, 1);
        firstNode.insertNewNode(firstNode, fourthNode, 1);

    }
}