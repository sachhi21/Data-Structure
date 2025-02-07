// See https://aka.ms/new-console-template for more information
using Tree;

public class Program
{
    
    public static string IntToRoman(int num)
    {
        string[] romanSymbols = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
        int[] values = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };

        string result = "";

        for (int i = 0; i < values.Length; i++)
        {
            while (num >= values[i])
            {
                result += romanSymbols[i];
                num -= values[i];
            }
        }

        return result;
    }

  

    public static void Main(string[] args)
    {
        //int num1 = 3749;
        //int num2 = 58;

        //Console.WriteLine(IntToRoman(num1));  // Output: "MMMDCCXLIX"
        //Console.WriteLine(IntToRoman(num2));

        //Tree<int> tree = new Tree<int>(1);
        //TNode<int> node1 = new TNode<int>(2);
        //TNode<int> node2 = new TNode<int>(3);
        //TNode<int> node3 = new TNode<int>(4);
        //tree.Root.insert(node1);
        //tree.Root.insert(node2);
        //tree.Root.insert(node3);
        //tree.Root.delete(node2);

        //var Treenon = new TreeNon("Root");
        //var child1 = new TreeNonGeneric("child1");
        //var child2 = new TreeNonGeneric("child2");

        //Treenon.Root.Addchild(child1);
        //Treenon.Root.Addchild(child2);
        //child1.Addchild(new TreeNonGeneric("grandchild1"));
        //child1.Addchild(new TreeNonGeneric("grandchild2"));
        //child2.Addchild(new TreeNonGeneric("grandchild1"));
        //child2.Addchild(new TreeNonGeneric("grandchild2"));
        //Treenon.Root.Addchild(new TreeNonGeneric("child3"));


        //Treenon.PrintTree(Treenon.Root);



        // LinkedList list = new LinkedList();
        // list.add(10);
        // list.add(20);
        // list.add(30);
        //// list.display();
        // list.addatnode(25, 3);
        // list.addatnode(5, 1);
        // list.addatnode(5, 6);
        // list.display();


        //LinkedListGeneric<string> list = new LinkedListGeneric<string>();
        //list.Add("sachin");
        //list.Add("abhu");
        //list.Add("ssss");
        //list.display();

        //list.AddAtPosition("nagamma", 3);
        //list.display();
        //list.Search("abhu");
        //Console.WriteLine(list.LengthofLinkedList());

        //list.Sort();

        BinaryTree tree = new BinaryTree();
        tree.Root=
         tree.Insert(tree.Root, 100);
        tree.Insert(tree.Root, 80);
        tree.Insert(tree.Root, 50);
        tree.Insert(tree.Root, 40);
        tree.Insert(tree.Root, 130);
        tree.Insert(tree.Root, 150);
        tree.Insert(tree.Root, 140);

        tree.LevelOrderTransveral(tree.Root);
        tree.PreOrderTraversal(tree.Root, 5);
        tree.InorderTraversal(tree.Root, 5);
        tree.PostTraversal(tree.Root, 5);






    }
}
