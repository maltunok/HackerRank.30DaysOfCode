class Node{
    public Node left,right;
    public int data;
    public Node(int data){
        this.data=data;
        left=right=null;
    }
}
class Solution{

	static int GetHeight(Node root)
    {
        if (root == null)
            return -1;

        int leftHeight = GetHeight(root.left);
        int rightHeight = GetHeight(root.right);

        if (leftHeight > rightHeight)
        {
            return leftHeight + 1;
        }
        else{
            return rightHeight + 1;
        }
    }

	static Node Insert(Node root, int data){
        if(root==null){
            return new Node(data);
        }
        else{
            Node cur;
            if(data<=root.data){
                cur=Insert(root.left,data);
                root.left=cur;
            }
            else{
                cur=Insert(root.right,data);
                root.right=cur;
            }
            return root;
        }
    }
    static void Main(String[] args){
        Node root=null;
        int T=Int32.Parse(Console.ReadLine());
        while(T-->0){
            int data=Int32.Parse(Console.ReadLine());
            root=Insert(root,data);            
        }
        int height=GetHeight(root);
        Console.WriteLine(height);
        
    }
}