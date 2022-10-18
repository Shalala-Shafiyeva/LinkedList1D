namespace ConsoleApp28
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> linkedlist = new LinkedList<int>();

            Node<int> a = new Node<int>(5);
            linkedlist.AddToEnd(a);
            Node<int> b = new Node<int>(11);
            linkedlist.AddToEnd(b);
            Node<int> c = new Node<int>(4);
            linkedlist.AddToEnd(c);
            Node<int> d = new Node<int>(7);
            linkedlist.AddToEnd(d);

            linkedlist.Output();

            Node<int> MaxEl = linkedlist.FindMaxNode();
            Console.WriteLine(MaxEl.Data);


            Console.ReadKey();


        }
    }
}