using System;
using System.Collections.Generic;

namespace Graph
{
    public class Vertex<T>
    {
        public T data;
        public LinkedList<Edge<T>> neighbors;
    }

    interface IVertex<T>
    {
        T Data
        {
            get;
            set;
        }
    }
}
