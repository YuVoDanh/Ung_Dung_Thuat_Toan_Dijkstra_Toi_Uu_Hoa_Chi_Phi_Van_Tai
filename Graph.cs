using System.Collections.Generic;

namespace WinFormsApp1
{
    public class Edge
    {
        public string Destination { get; set; }

        public double Distance { get; set; }

        public Edge(string destination, double distance)
        {
            Destination = destination;
            Distance = distance;
        }
    }

    public class Graph
    {
        public Dictionary<string, List<Edge>>
            AdjacencyList = new Dictionary<string, List<Edge>>();

        public void AddEdge(string source, string destination, double distance)
        {
            if (!AdjacencyList.ContainsKey(source))
            {
                AdjacencyList[source] = new List<Edge>();
            }

            if (!AdjacencyList.ContainsKey(destination))
            {
                AdjacencyList[destination] = new List<Edge>();
            }

            AdjacencyList[source].Add(new Edge(destination, distance));

            AdjacencyList[destination].Add(new Edge(source, distance));
        }
    }
}