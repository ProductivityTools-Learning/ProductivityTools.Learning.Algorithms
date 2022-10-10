using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DFS.Learning
{
    internal class DFSLearn3
    {
        Stack<Node> paths = new Stack<Node>();
        public Node Find(Node node, string filter)
        {
            this.paths.Push(node);
            if(node.Name==filter)
            {
                return node;
            }

            foreach(var childNode in node.Nodes)
            {
                return Find(childNode, filter);
            }
            this.paths.Pop();
            return null;
        }
    }
}
