using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dijkstra.Learning
{
    internal class DijkstraLearn8
    {
        EdgePriorityQueue edgePriorityQueue = new EdgePriorityQueue();
        List<Node> visited = new List<Node>();
        Dictionary<Node, int> pathTo = new Dictionary<Node, int>();
        public void FindPath(Node startNode, string filter)
        {
            Visit(startNode);
            while (this.edgePriorityQueue.Count > 0)
            {
                var edge = this.edgePriorityQueue.Dequene();
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

                if (this.pathTo.ContainsKey(edge.To) == false ||
                    this.pathTo[edge.To] > (this.pathTo[edge.From] + edge.Weight))
                {
                    this.pathTo[edge.To] = this.pathTo[edge.From] + edge.Weight;
                }
            }
        }
    }
}
}
