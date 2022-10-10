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
        Node twelfthNode = new Node(12);
        Node thirteenthNode = new Node(13);
        Node fourteenthNode = new Node(14);
        Node fifteenthNode = new Node(15);

        List<int> listReturned = new List<int>();

        Methods firstTree = new Methods();

        firstTree.insertNewNode(firstNode, secondNode);
        firstTree.insertNewNode(firstNode, thirdNode, 1);
        firstTree.insertNewNode(firstNode, fourthNode, 0, 2);
        firstTree.insertNewNode(firstNode, fifthNode, 1, 2);
        firstTree.insertNewNode(firstNode, sixthhNode, 0, 3);
        firstTree.insertNewNode(firstNode, seventhNode, 1, 3);
        firstTree.insertNewNode(firstNode, eightNode, 0, 5);
        firstTree.insertNewNode(firstNode, ninthNode, 0, 8);
        firstTree.insertNewNode(firstNode, thenthNode, 1, 8);
        firstTree.insertNewNode(firstNode, eleventhNode, 0, 9);
        firstTree.insertNewNode(firstNode, twelfthNode, 7);
        firstTree.insertNewNode(firstNode, thirteenthNode, 1, 7);
        firstTree.insertNewNode(firstNode, fourteenthNode, 0, 6);
        firstTree.insertNewNode(firstNode, fifteenthNode, 1, 14);


        Console.WriteLine("Method in_order: " + firstTree.traverseIn_Order(firstNode));
        
        Console.WriteLine("/*/*/*/*/*/*/*");
        
        Console.WriteLine("Method post_order: " + firstTree.traversePost_Order(firstNode));
        
        Console.WriteLine("/*/*/*/*/*/*/*");

        Console.WriteLine("Method pre_order: " + firstTree.traversePre_Order(firstNode));

        Console.WriteLine("/*/*/*/*/*/*/*");

        Console.WriteLine("The level of the tree is: " + firstTree.levelCounter(firstNode));

        Console.WriteLine("/*/*/*/*/*/*/*");

        listReturned =  firstTree.searchNode(firstNode, 13);
        
        Console.WriteLine("/*/*/*/*/*/*/*");

        Console.WriteLine(firstTree.getTreeStructure(firstNode));

        Console.WriteLine("/*/*/*/*/*/*/*");

        //firstTree.delete(firstNode, 8);

        //Console.WriteLine("/*/*/*/*/*/*/*");


    }
}