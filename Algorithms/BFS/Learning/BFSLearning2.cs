using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BFS.Learning
{
    internal class BFSLearning2
    {
        Queue<Node> queue=new Queue<Node>();
        HashSet<Node> visited=new HashSet<Node>();
        Dictionary<Node, Node> parents = new Dictionary<Node, Node>();
        public Node Search(Node startNode, string filter)
        {
            this.queue.Enqueue(startNode);
            while(queue.Count > 0)
            {
                Node node = queue.Dequeue();
                if (node.Name==filter)
                {
                    return node;
                }

                foreach(var childNode in node.Nodes)
                {
                    if (this.visited.Contains(childNode) == false)
                    {
                        this.parents.Add(childNode, node);
                        this.queue.Enqueue(childNode);
                    }
                }
            }

            throw new Exception("Node not found");
        }
    }
}
