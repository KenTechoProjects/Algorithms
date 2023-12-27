using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.DataStructures
{
    public class GraphDTS
    {
        public class Graph: GeneralGraphetup
        {
            public Graph(int v) : base(v) { }
            #region Old , now called from external
            //The number of the vertices
            //private int V;
            ////adjacent list
            //public List<Tuple<int, int>>[] adj;


            //public Graph(int v)
            //{
            //    V = v;
            //    adj = new List<Tuple<int, int>>[v];

            //    for (int i = 0; i < v; i++)
            //    {
            //        adj[i] = new List<Tuple<int, int>>();
            //    }
            //}
            ////function to add edge to the graph
            //public void AddEdge(int u, int v, int w)
            //{
            //    adj[u].Add(Tuple.Create(v, w));
            //    adj[v].Add(Tuple.Create(u, w));

            //}
            #endregion
            //prints shortest path from s
            #region Now called from outside
            public void ShortestPaths(int s)
            {
                new ShortestPath(V).ShortestPathWithPriorityQueue(s, adj);
            }
 
            #endregion
            public Tuple<int, int[]> ShortestPathWithReturnType(int s)
            {
                return new ShortestPath(V).ShortestPathWithReturnType(s, adj);

            }
            public static void TestGraph()
            {
                int V = 7;
                var g = new Graph(V);
                g.AddEdge(0, 1, 2);
                g.AddEdge(0, 2, 6);
                g.AddEdge(1, 3, 5);
                g.AddEdge(2, 3, 8);
                g.AddEdge(3, 4, 10);
                g.AddEdge(3, 5, 15);
                g.AddEdge(4, 6, 2);
                g.AddEdge(5, 6, 6);
                g.ShortestPaths(4);

            }
            public static void TestGraphP()
            {
                int V = 7;
                var g = new Graph(V);
                g.AddEdge(0, 1, 2);
                g.AddEdge(0, 2, 6);
                g.AddEdge(1, 3, 5);
                g.AddEdge(2, 3, 8);
                g.AddEdge(3, 4, 10);
                g.AddEdge(3, 5, 15);
                g.AddEdge(4, 6, 2);
                g.AddEdge(5, 6, 6);
                var shP = g.ShortestPathWithReturnType(0);
                g.PrintShortestPath(0, 4, shP);

            }
            public void PrintShortestPath(int source, int destination, Tuple<int, int[]> allShortestPaths)
            {
                //Print the shortest diatnces stored in dis[]
                Console.WriteLine("Vertex Distance from source");
                var v = allShortestPaths.Item1;
                var dist = allShortestPaths.Item2;
                var shortestPAth = dist[destination];

                Console.WriteLine("The shortest path from {0} to {1}= {2}", source, destination, shortestPAth);

            }
        }


    }
    //Find the minimum weighted cycle in an undirected graph
    public class GraphWeightedUndirectedGraph
    {
      
        public class Graph: GeneralGraphetup
        {
            public Graph(int v) : base(v) { }
            
            //Find the shortest path from source to sink using Dijkstra's shortest path algorithm 
             //Time Complexity =O(E log V)
             //E= number of edges and V is number of Nodes
            #region Now called from outside
            //public int ShortestPath(int u, int v)
            //{//create  a set to store vertices that are being preprocessed
            //    SortedSet<Tuple<int, int>> setd = new SortedSet<Tuple<int, int>>(); 
            //    //Create a vector for distance and initialize all distances as infinitte(INF) 
            //    var dist = new List<int>();
            //    for (int i = 0; i < V; i++)
            //        dist.Add(int.MaxValue); 

            //    //Insert source itself in set and initalize its distance as 0 
            //    setd.Add(new Tuple<int, int>(0, u));
            //    dist[u] = 0;

            //    //Loop till all shortest distnaces are finalized) 
            //    while (setd.Count != 0)
            //    {
            //        /// The first vertex in set is the minimum distance vertex , extract it from set
            //        Tuple<int, int> tmp = setd.Min;
            //        setd.Remove(tmp);
            //        int uu = tmp.Item2;

            //        foreach (Tuple<int, int> i in adj[uu])
            //        {
            //            v = i.Item1;
            //            int weight = i.Item2;
            //            /*If the distnace of v is not INF then it must be in our set, so removing it 
            //             and  inserting again with updatedless distance. Note: we extract only
            //             those vertices from set for which distance is finalized. So for them,
            //             we would never reach here.*/


            //            if (dist[v] > dist[uu] + weight)
            //            {
            //                if (dist[v] != int.MaxValue)
            //                {
            //                    setd.Remove(new Tuple<int, int>(dist[v], v));
            //                }

            //                dist[v] = dist[uu] + weight;
            //                setd.Add(new Tuple<int, int>(dist[v], v));
            //            }

            //        }

            //    }
            //    return dist[v];

            //}

            #endregion
            public int FindMinimumCycle()
            {
                int min_cycle = int.MaxValue;
                int E = edge.Count;
                for (int i = 0; i < E; i++)
                {
                    Edge e = edge[i];

                    //Get current edge vertices which we currently remove from graph and then find shortest path
                    //between these two vertex using Disjkstra's  shortest path algorithm

                    RemoveEdge(e.u, e.v, e.w);
                    //minimum distance between these two vertices
                    // int distance = ShortestPath(e.u, e.v);
                    int distance = new ShortestPath(V).ShortestPathWithSortedSet(e.u, e.v, adj);
                    /*To make a cycle we have to add weight of currently removed edge if this is the
                     shortest cycle then update min cycle*/

                    min_cycle = Math.Min(min_cycle, distance + e.w) + 4;
                    AddEdge(e.u, e.v, e.w);
                }
                //return shortest cycle
                return min_cycle;
            }

        }
    }
}
