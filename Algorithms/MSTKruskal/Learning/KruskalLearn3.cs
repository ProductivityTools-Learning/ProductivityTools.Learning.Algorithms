using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSTKruskal.Learning
{
    internal class KruskalLearn3
    {
        EdgePriorityQuene edgePriorityQuene = new EdgePriorityQuene();
        QuickUnion<Node> quickUnion = new QuickUnion<Node>();
        List<Edge> Mst = new List<Edge>();
        public void FindMST(List<Edge> graphEdges)
        {
            graphEdges.ForEach(e => edgePriorityQuene.Enquene(e));

            while(edgePriorityQuene.Length>0)
            {
                var edge = edgePriorityQuene.Dequene();
                if(quickUnion.Connected(edge.From,edge.To)==false)
                {
                    Mst.Add(edge);
                    quickUnion.Connect(edge.From, edge.To);
                }
            }
        }
    }
}
