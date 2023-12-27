using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.DataStructures
{
  public  class GraphDataStructure
    {
        private int _totalVertise;
        private LinkedList<int>[] _linkedListArray;

        public GraphDataStructure(int n)
        {
            _totalVertise = n;
            _linkedListArray = new LinkedList<int>[n];
            for(int i = 0; i < n; ++i)
            {
                _linkedListArray[i] = new LinkedList<int>();
            }
        }

        public void addEdge(int vertex, int adVertex)
        {
            _linkedListArray[vertex].AddLast(adVertex);
        }
        public void PrintAdajacentList()
        {

        }
        public void PrintAdjaceyMatrix(int? [,] adjanceyMatrix,int count)
        {

        }
    }
}
