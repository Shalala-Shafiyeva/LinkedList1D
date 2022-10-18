using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28
{
    internal partial class Program
    {
        public class LinkedList<T>
        {
            public Node<T> Head;
            public Node<T> Tail;
            public int Count;

            public LinkedList()
            {
                Head = null;
                Tail = null;
                Count = 0;
            }

            public void AddToEnd(Node<T> newNode)
            {
                if (Head == null)
                {
                    Head = newNode;
                    Tail= newNode;
                }
                Tail.Next = newNode;
                Tail = newNode; ;
                Count++;
            }
            
            public void Output()
            {
                Node<T> runner= Head;
                while(runner != null)
                {
                    Console.WriteLine(runner.Data);
                    runner = runner.Next;
                }
            }

            public Node<T> FindMaxNode()
            {
                Node<T> MaxNode = Head;
                Node<T> runner = Head;
                while (runner != null)
                {
                    if (Convert.ToInt32(runner.Data) > Convert.ToInt32(MaxNode.Data)) MaxNode = runner;
                    runner=runner.Next;
                }
                return MaxNode;
            }
        }
    }
}
