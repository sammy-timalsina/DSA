namespace DSA.BinaryTrees
{
    public class BinaryTree
    {
        public BT_Node constructBT(int[] arr)
        {
            //step1: create a root node
            BT_Node root = new BT_Node(null,null, arr[0]);
            //Step2: create  a pair
            BT_Pair rp = new BT_Pair(root, 1);
            Stack<BT_Pair> st = new Stack<BT_Pair>();
            st.Push(rp);
            int idx= 0;
            while(st.Count > 0)
            {
                BT_Pair top = st.Peek();
                    if(top.state == 1) //if left //increment state 2
                    {
                        idx++;
                        if(arr[idx]!= -1)
                        {
                            BT_Node temp = new BT_Node(null, null, arr[idx]);
                            top.node.left = temp;
                            st.Push(new BT_Pair(temp,1));
                        }
                        else
                        {
                            top.node.left = null;
                        }
                         top.state++;
                    }
                    else if(top.state == 2) //if right //increment state 3
                    {
                        idx++;
                        if(arr[idx] != -1)
                        {
                            BT_Node temp = new BT_Node(null, null, arr[idx]);
                            top.node.right = temp;
                            st.Push(new BT_Pair(temp,1));
                        }
                        else
                        {
                            top.node.right = null;
                        }
                        top.state++;
                    }
                    else //state:3 Pop
                    {
                        st.Pop();
                    }
            }
          return root;
        }
        public void displayBT(BT_Node node)
        {
            if (node == null)
                return;
            string rootNode = node.data.ToString();
            string leftNodeVal = "";
            string rightNodeVal = "";
            if (node.left != null)
            {
                leftNodeVal = node.left.data.ToString();
            }
            else
            {
                leftNodeVal = ".";
            }
            if (node.right != null)
            {
                rightNodeVal = node.right.data.ToString();
            }
            else
                rightNodeVal = ".";
            string fr = leftNodeVal + "-" + rootNode + "-" + rightNodeVal;
            Console.WriteLine(fr);

            displayBT(node.left);
            displayBT(node.right);
        }
    }
}