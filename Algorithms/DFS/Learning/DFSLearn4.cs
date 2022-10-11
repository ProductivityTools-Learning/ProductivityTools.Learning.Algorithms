using DFS;
public class DFSLearn4
{
    HashSet<Node> Visited=new HashSet<Node>();
    Stack<Node> Path=new Stack<Node>();
    public Node Find(Node node, string value)
    {
        this.Path.Push(node);
        if(node.Name==value)
        {
            return node;
        }
        if(this.Visited.Contains(node)==false)
        {
            this.Visited.Add(node);
            foreach(var childNode in node.Nodes)
            {
                return Find(childNode,value);
            }
        }
        this.Path.Pop();
        return null;
    }
}