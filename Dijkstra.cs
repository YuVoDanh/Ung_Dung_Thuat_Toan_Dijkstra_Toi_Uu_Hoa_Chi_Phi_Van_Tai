using System.Collections.Generic;
using System.Linq;

namespace WinFormsApp1
{
    public class Dijkstra
    {
        public static (double distance, List<string> path) FindShortestPath(Graph graph, string start, string end)
        {
            var distances = new Dictionary<string, double>();

            var previous = new Dictionary<string, string>();

            var nodes = new List<string>();

            foreach (var node in graph.AdjacencyList.Keys)
            {
                distances[node] = double.MaxValue;

                previous[node] = null;

                nodes.Add(node);
            }

            distances[start] = 0;

            while (nodes.Count > 0)
            {
                nodes = nodes.OrderBy(n => distances[n]).ToList();

                string smallest = nodes[0];

                nodes.Remove(smallest);

                if (smallest == end)
                {
                    List<string> path = new List<string>();

                    while (previous[smallest] != null)
                    {
                        path.Add(smallest);

                        smallest = previous[smallest];
                    }

                    path.Add(start);

                    path.Reverse();

                    return (distances[end], path);
                }

                foreach (var neighbor in graph.AdjacencyList[smallest])
                {
                    double alt = distances[smallest] + neighbor.Distance;

                    if (alt < distances[neighbor.Destination])
                    {
                        distances[neighbor.Destination] = alt;

                        previous[neighbor.Destination] = smallest;
                    }
                }
            }

            return (0, new List<string>());
        }
    }
}