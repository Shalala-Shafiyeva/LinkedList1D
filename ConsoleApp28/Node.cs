using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28
{
    internal partial class Program
    {
        public class Node<T>
        {
            public T Data;
            public Node<T> Next;

            public Node( T data)
            {
                Data = data;
                Next = null;
            }
        }
    }
}
