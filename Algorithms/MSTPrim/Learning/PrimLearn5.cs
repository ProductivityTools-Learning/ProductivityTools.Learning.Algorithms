using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSTPrim.Learning
{
    internal class PrimLearn5
    {
        EdgePriorityQueue EdgePriorityQueue = new EdgePriorityQueue();
        List<Edge> Mst = new List<Edge>();
        List<Node> Visited = new List<Node>();
        public void FindMST(Node startNode)
        {
            Visit(startNode);
            while (this.EdgePriorityQueue.Count > 0)
            {
                Edge edge = this.EdgePriorityQueue.Dequene();
                
                if (this.Visited.Contains(edge.To) == false)
                {
                    this.Mst.Add(edge);
                    Visit(edge.To);
                }
            }
        }

        private void Visit(Node node)
        {
            this.Visited.Add(node);
            foreach (var edge in node.Edges)
            {
                this.EdgePriorityQueue.Enquene(edge);
            }
        }
    }
}
