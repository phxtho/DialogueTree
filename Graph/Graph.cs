using System;
using System.Collections.Generic;
using System.Text;

namespace Graph
{
    class Graph<T>
    {
        List<Vertex<T>> vertices;

        public void AddNode(Vertex<T> node)
        {
            vertices.Add(node);
        }

        public void AddEdge(Vertex<T> from, Vertex<T> to)
        {
            Edge<T> newEdge = new Edge<T> { nodeFrom = from, nodeTo = to };
            from.neighbors.AddLast(newEdge)
        }
    }
}
