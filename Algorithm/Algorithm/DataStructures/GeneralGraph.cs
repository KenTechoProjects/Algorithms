using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.DataStructures
{
    public class Edge
    {
        public int u;
        public int v;
        public int w;//weight
    }
    public class GeneralGraphetup
    {
        public List<Edge> edge;
        //The number of the vertices
        internal int V;
        //adjacent list
        internal List<Tuple<int, int>>[] adj;


        public GeneralGraphetup(int v)
        {
            V = v;
            adj = new List<Tuple<int, int>>[v];
            edge = new List<Edge>();
            for (int i = 0; i < v; i++)
            {
                adj[i] = new List<Tuple<int, int>>();
            }
        }
        //function to add edge to the graph
        public void AddEdge(int u, int v, int w)
        {
            adj[u].Add(Tuple.Create(v, w));
            adj[v].Add(Tuple.Create(u, w));
            Edge e = new Edge { u = u, v = v, w = w };
            edge.Add(e);
        }
        public void RemoveEdge(int u, int v, int w)
        {
            adj[u].Remove(new Tuple<int, int>(v, w));
            adj[v].Remove(new Tuple<int, int>(u, w));
        }
    }
}
