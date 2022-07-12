using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Graphs
{
    public class Graph
    {
        public IList<IList<Edge>> constructAGraph()
        {
           // IList<IList<Edge>> graphLists = new List<IList<Edge>>();
       
            IList<Edge>[] graphs = new List<Edge>[7];
            for(int i = 0; i < graphs.Length; i++)
            {
                graphs[i] = new List<Edge>();
            }
            graphs[0].Add(new Edge(0, 3, 40));
            graphs[0].Add(new Edge(0, 1, 10));
          
            graphs[1].Add(new Edge(1,0,10));
            graphs[1].Add(new Edge(1,2,10));

            graphs[2].Add(new Edge(2,3,10));
            graphs[2].Add(new Edge(2,1,10));

            graphs[3].Add(new Edge(3,0,40));
            graphs[3].Add(new Edge(3,2,10));
            graphs[3].Add(new Edge(3,4,2));

            graphs[4].Add(new Edge(4,3,2));
            graphs[4].Add(new Edge(4,5,3)); 
            graphs[4].Add(new Edge(4,6,8));

            graphs[5].Add(new Edge(5,4,3));
            graphs[5].Add(new Edge(5,6,3));

            graphs[6].Add(new Edge(6,5,3));
            graphs[6].Add(new Edge(6,8,3));

            //graphLists = graphs;

            //graphLists.Add(graphs[0]);
            //graphLists.Add(graphs[1]);
            //graphLists.Add(graphs[2]);
            //graphLists.Add(graphs[3]);
            //graphLists.Add(graphs[4]);
            //graphLists.Add(graphs[5]);
            //graphLists.Add(graphs[6]);

            return graphs;
        }
    }
}
