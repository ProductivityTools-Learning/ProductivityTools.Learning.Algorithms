using Dijkstra;

public class DijkstraLearn9
{
    HashSet<Node> visited = new HashSet<Node>();
    EdgePriorityQueue edgePriorityQueue = new EdgePriorityQueue();
    Dictionary<Node, int> PathTo = new Dictionary<Node, int>();
    public void FindPath(Node startNode, string node)
    {
        Visit(startNode);
        while (edgePriorityQueue.Count > 0)
        {
            var edge = edgePriorityQueue.Dequene();
            if (this.visited.Contains(edge.To) == false)
            {
                Visit(edge.To);
            }
        }
    }

    private void Visit(Node node)
    {
        this.visited.Add(node);
        foreach (var edge in node.Edges)
        {
            this.edgePriorityQueue.Enquene(edge);
        }

        foreach (var edge in node.Edges)
        {
            if (this.PathTo.Keys.Contains(edge.To) == false ||
            this.PathTo[edge.To] > this.PathTo[edge.From] + edge.Weight)
            {
                this.PathTo[edge.To] = this.PathTo[edge.From] + edge.Weight;
            }
        }
    }
}