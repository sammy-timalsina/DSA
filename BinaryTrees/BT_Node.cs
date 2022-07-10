namespace DSA.BinaryTrees
{
    public class BT_Node
    {
        public BT_Node left;
        public BT_Node right;
        public int data;

        public BT_Node(BT_Node left, BT_Node right, int data)
        {
            this.left = left;
            this.right = right;
            this.data = data;
        }
    }
}