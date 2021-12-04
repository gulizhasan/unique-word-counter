using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3assignment
{
    class Node<T> where T : IComparable
    {
        private T data;
        public Node<T> Left, Right;

        public Node(T item) //constructor with an item of type T
        {
            data = item;
            Left = null;
            Right = null;
        }
        public T Data //property for data
        {
            set { data = value; }
            get { return data; }
        }
    }
}
