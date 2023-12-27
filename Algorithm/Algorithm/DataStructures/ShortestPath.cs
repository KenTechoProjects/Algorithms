using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.DataStructures
{
   public class ShortestPath
    {
        private int V;
       public ShortestPath(int V)
        {
            this.V = V;
        }
        public int ShortestPathWithSortedSet(int u, int v, List<Tuple<int, int>>[] adj)
        {//create  a set to store vertices that are being preprocessed
            SortedSet<Tuple<int, int>> setd = new SortedSet<Tuple<int, int>>();
            //Create a vector for distance and initialize all distances as infinitte(INF) 
            var dist = new List<int>();
            for (int i = 0; i < V; i++)
                dist.Add(int.MaxValue);

            //Insert source itself in set and initalize its distance as 0 
            setd.Add(new Tuple<int, int>(0, u));
            dist[u] = 0;

            //Loop till all shortest distnaces are finalized) 
            while (setd.Count != 0)
            {
                /// The first vertex in set is the minimum distance vertex , extract it from set
                Tuple<int, int> tmp = setd.Min;
                setd.Remove(tmp);
                int uu = tmp.Item2;

                foreach (Tuple<int, int> i in adj[uu])
                {
                    v = i.Item1;
                    int weight = i.Item2;
                    /*If the distnace of v is not INF then it must be in our set, so removing it 
                     and  inserting again with updatedless distance. Note: we extract only
                     those vertices from set for which distance is finalized. So for them,
                     we would never reach here.*/


                    if (dist[v] > dist[uu] + weight)
                    {
                        if (dist[v] != int.MaxValue)
                        {
                            setd.Remove(new Tuple<int, int>(dist[v], v));
                        }

                        dist[v] = dist[uu] + weight;
                        setd.Add(new Tuple<int, int>(dist[v], v));
                    }

                }

            }
            return dist[v];

        }

        public void ShortestPathWithPriorityQueue(int s,List<Tuple<int, int>>[] adj)
        {//create a priority queue to stroe vertices that are being perprocessed
            var pq = new PriorityQue<Tuple<int, int>>();

            //Create a vector for distance and initialize all distances as infinitte(INF)

            var dist = new int[V];
            for (int i = 0; i < V; i++)
                dist[i] = int.MaxValue;


            //Insert source itself in priority queue and initalize its distance as 0

            pq.EnQueue(Tuple.Create(0, s));
            dist[s] = 0;

            //Loop till priority queue becomes empty ( or all distnaces are not finalized)

            while (pq.Count != 0)
            {
                /* The first vertex inn apir is the minimum distance vertex , extract it form the 
                 * priority queue. Vertex label is stored in second of pair 
                 * (it has to be done this way to keep the vertices sorted distance
                 * ( distance must be first item in a pair))*/
                var u = pq.Dequeue().Item2;
                // 'i' is used to get all adjencent vertices of a vertex

                foreach (var i in adj[u])
                {//Get vertex label and weight of current adjecent of u

                    int v = i.Item1;
                    int weight = i.Item2;

                    //If there is shorted path to v throug u
                    if (dist[v] > dist[u] + weight)
                    {
                        //Updating distance of v
                        dist[v] = dist[u] + weight;
                        pq.EnQueue(Tuple.Create(dist[v], v));
                    }

                }

            }

            //Print the shortest diatnces stored in dis[]
            Console.WriteLine("Vertex Distance from source");
            for (int i = 0; i < V; i++)
            {
                Console.WriteLine("{0}\t\t{1}", i, dist[i]);
            }
        }

        public Tuple<int, int[]> ShortestPathWithReturnType(int s,List<Tuple<int, int>>[] adj)
        {//create a priority queue to stroe vertices that are being perprocessed
            var pq = new PriorityQue<Tuple<int, int>>();

            //Create a vector for distance and initialize all distances as infinitte(INF)

            var dist = new int[V];
            for (int i = 0; i < V; i++)
                dist[i] = int.MaxValue;


            //Insert source itself in priority queue and initalize its distance as 0

            pq.EnQueue(Tuple.Create(0, s));
            dist[s] = 0;

            //Loop till priority queue becomes empty ( or all distnaces are not finalized)

            while (pq.Count != 0)
            {
                /* The first vertex inn apir is the minimum distance vertex , extract it form the 
                 * priority queue. Vertex label is stored in second of pair 
                 * (it has to be done this way to keep the vertices sorted distance
                 * ( distance must be first item in a pair))*/
                var u = pq.Dequeue().Item2;
                // 'i' is used to get all adjencent vertices of a vertex

                foreach (var i in adj[u])
                {//Get vertex label and weight of current adjecent of u

                    int v = i.Item1;
                    int weight = i.Item2;

                    //If there is shorted path to v throug u
                    if (dist[v] > dist[u] + weight)
                    {
                        //Updating distance of v
                        dist[v] = dist[u] + weight;
                        pq.EnQueue(Tuple.Create(dist[v], v));
                    }

                }

            }

            return Tuple.Create(V, dist);


        }
    }
}
