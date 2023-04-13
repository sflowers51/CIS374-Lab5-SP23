using System;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            UndirectedGraph undirectedGraph = new UndirectedGraph("../../../graphs/graph1.txt");

            Console.WriteLine(undirectedGraph);

            var a = undirectedGraph.GetNodeByName("a");
            undirectedGraph.DFS(a);
        }
    }
}
