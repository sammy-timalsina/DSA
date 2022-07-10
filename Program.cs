using DSA.BinaryTrees;

namespace DSA
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            //given an array
            //assumption: -1 represent null in a binary tree
            int [] arr = new int[]{50,25,12,-1,-1,37,30,-1,-1,-1,75,62,-1,70,-1,-1,87,-1,-1};
            BinaryTree bt = new BinaryTree();
            BT_Node nd = bt.constructBT(arr);
            Console.WriteLine("Hello World!");
        }
    }
}