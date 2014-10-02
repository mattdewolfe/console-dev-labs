using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5
{
    class Node<T>
    {
        public Node<T> next;
        public T data;

        // Create an empty node
        public Node()
        {
            data = default(T);
            next = null;
        }
        // Create a node with data and a next target
        public Node(T _data, Node<T> _next)
        {
            next = _next;
            data = _data;
        }
    }
}
