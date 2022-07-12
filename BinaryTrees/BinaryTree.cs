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
                        if(arr[idx]!= -11111)
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
                        if(arr[idx] != -11111)
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
        public int sizeOfABT(BT_Node node)
        {
            if(node == null)
            {
                return 0;
            }           
            return 1+ sizeOfABT(node.left) +sizeOfABT(node.right);           
        }
        public int sumOFaBT(BT_Node node)
        {

            if (node == null)
                return 0;
            return node.data + sumOFaBT(node.left) + sumOFaBT(node.right);
        }
        public int maxOfaBT(BT_Node node)
        {
            if( node == null)
            {
                return int.MinValue;
            }          
            int leftMax = maxOfaBT(node.left);
            int rightMax = maxOfaBT(node.right);    
            int max = Math.Max(leftMax, rightMax);
            max = Math.Max(node.data, max);
            return max;
        }
        public int heightOfABT(BT_Node node)
        {
            if (node == null)
                return -1;
            int leftHt = heightOfABT(node.left);
            int rightHt = heightOfABT(node.right);
            return 1+ Math.Max(leftHt,rightHt);
        }
        private Stack<BT_Node> stack = new Stack<BT_Node>();
        BT_Node leftSideNodes = null;
        BT_Node rightSideNodes = null;
        BT_Node leftSideNodes1 = null;
        BT_Node rightSideNodes1 = null;
        BT_Node leftSideNodes2 = null;
        BT_Node rightSideNodes2 = null;
        BT_Node mn = new BT_Node(null,null,0);
        public BT_Node mergeTwoBT(BT_Node root1, BT_Node root2)
        {
          
        if(root1==null)
            {
                return root2;
            }
        if(root2==null)
            {
                return root1;
            }
           root1.data = root1.data + root2.data;
            root1.left = mergeTwoBT(root1.left , root2.left);
            root1.right =mergeTwoBT( root1.right , root2.right);

            stack.Push(mn);
            return root1; ;
        }
        IList<double> bucket= new List<double>();
        public IList<double> AvgBT(BT_Node root)
        {
            if(root ==null)
            {
                return new List<double>();  
            }
            IList<double> bucket1 = AvgBT(root.left);
            IList<double> bucket2 = AvgBT(root.right);
            IList<double> bucket3 = new List<double>();
            bucket3.Add(root.data);
            int len1 = bucket1.Count;
            int len2 = bucket2.Count;
            int len = 0;
            len = Math.Max(len1, len2);
            double avg = 0;
            for(int i = 0;i<len;i++)
            {
                if (i < len1 && i < len2)
                {
                    avg = (bucket1[i] + bucket2[i]) / 2;
                }
                else if( i < len1 && i >= len2)
                {
                    avg = bucket1[i];
                }
                else if(  i < len2 && i >= len1)
                {
                    avg = bucket2[i];
                }
                bucket3.Add(avg);
            }          
            return bucket3;

        }
    }
}