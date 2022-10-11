using BFS;

public class BFSLearning3
{
    HashSet<Node> visited=new HashSet<Node>();
    Queue<Node> quene=new Queue<Node>();
    Dictionary<Node,Node> Parents=new Dictionary<Node,Node>();

    public Node Find(Node startNode, string name)
    {
        this.quene.Enqueue(startNode);

        while(quene.Count>0)
        {
            var node=quene.Dequeue();
            if (node.Name==name)
            {
                return node;
            }
            if (this.visited.Contains(node)==false)
            {
                this.visited.Add(node);
                foreach(var childNode in node.Nodes)
                {
                    this.Parents.Add(childNode,node);
                    quene.Enqueue(childNode);
                }
            }
        }

        throw new Exception("Node not found!");
    }
}