using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.DataStructures
{
    public class Graph_PathWithSmallestProductOfEdgeWithWeightGreaterThanOne
    {
        public class Pair : IComparable<Pair>
        {
            public int First, Second;
            public Pair(int first, int second)
            {
                First = first;
                Second = second;
            }
            public int CompareTo(Pair pair)
            {
                if (First == pair.First)
                {
                    return Second - pair.Second;
                }
                return First - pair.First;
            }


            public class GFG
            {
                //method to return the smallest XOR som of Edges
                //s=SOurce; d=Destination
                public static int Dijkstra(int s, int d, List<List<Pair>> gr)
                {
                    //If the source is equal to the destination
                    if (s == d)
                        return 0;

                    //Initialize the priority queque

                    SortedSet<Pair> pq = new SortedSet<Pair>();
                    pq.Add(new Pair(1, s));


                    //Visited array

                    bool[] v = new bool[gr.Count];

                    //while the pq is not empty
                    while (pq.Count != 0)
                    {
                        //Current node
                        Pair p = pq.Min;
                        pq.Remove(p);
                        int curr = p.Second;

                        //Current XOR sum of distance

                        int dist = p.First;

                        //If already visited continue
                        
                            if (v[curr])
                                continue;

                            //marking the node as visited
                            v[curr] = true;
                            //If it is a destination node

                            if (curr == 0)
                                return dist;

                            //Traversing the current node
                            foreach (Pair item in gr[curr])
                            {
                                pq.Add(new Pair(dist ^ item.Second, item.First));
                            }
                     
                    }



                    return -1;
                }

            }
            public class TestGFG
            {
                public static void GetPathWithTheSmallestProductOfEdge()
                {
                    int n = 3;
                    List<List<Pair>> graph = new List<List<Pair>>();
                    for (int i = 0; i < n+1; i++)
                    {
                        graph.Add(new List<Pair>());
                    }

                    //Input edges
                    graph[1].Add(new Pair(3, 9));
                    graph[2].Add(new Pair(3, 1));
                    graph[1].Add(new Pair(2, 5));

                    //Source and Destination
                    int s = 1; int d = 3;
                    Console.WriteLine(GFG.Dijkstra(s, d, graph));
                }
            }
        }
    }
}
