using System;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            IMovieCollection amovieCollection = new BTreeNode();

            Console.WriteLine("Adding m to the BST");

            amovieCollection.Insert('m');

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("print");
            amovieCollection.Display();
        }
    }   
}
