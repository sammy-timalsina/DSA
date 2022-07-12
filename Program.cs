using DSA.BinaryTrees;
using DSA.Graphs;

namespace DSA
{
    class Program
    {
        static void Main(string[] args)
        {

            Graph graph = new Graph();
            IList<IList<Edge>> graphs = graph.constructAGraph();
            //given an array
            //assumption: -1 represent null in a binary tree
            //  int[] root1 =new int[] { 1, 3,-1,-1, 2,-1,-1 };
            //int[] root2 =new int[]{ 4, 7,-1,-1, 6,-1,-1};
            //int[] root1 = new int[] { 1, 3, 5,-1,-1,-1,2,-1,-1};
            //int[] root2 = new int[] {2,1,-1,4,-1,-1,3,-1,7,-1,-1 };
            int [] arr = new int[]{50,25,12,-1,-1,37,30,-1,-1,-1,75,62,-1,70,-1,-1,87,-1,-1};
            BinaryTree bt = new BinaryTree();
          //  BT_Node nd1 = bt.constructBT(root1);
          //  BT_Node nd2 = bt.constructBT(root2);
           BT_Node nd = bt.constructBT(arr);
           
          //  BT_Node mg = bt.mergeTwoBT(nd1, nd2);
           IList<double> buck = bt.AvgBT(nd);
                bt.displayBT(nd);
            int x = bt.sizeOfABT(nd);   
            int sumOFAllNodes = bt.sumOFaBT(nd);
            int maxOFNodes = bt.maxOfaBT(nd);
            int heightOFABT = bt.heightOfABT(nd);
            Console.WriteLine("Hello World!");
        }
    }
}