using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrivialPursuit.Classes
{
    class Algorithms
    {
        public HashSet<T> BFS<T>(Graph<T> graph, T start, int maxDepth, Action<T> preVisit = null)
        {
            var visited = new HashSet<T>();
            var resultado = new HashSet<T>();

            if (!graph.AdjacencyList.ContainsKey(start))
                return visited;

            var queue = new Queue<Tuple<T, int>>();
            // Consider the start is in the depth "0"
            queue.Enqueue(new Tuple<T, int>(start, 0));

            while (queue.Count > 0)
            {
                Tuple<T, int> vertexWithDepth = queue.Dequeue();
                var vertex = vertexWithDepth.Item1;

                if (visited.Contains(vertex))
                    continue;

                if (preVisit != null)
                    preVisit(vertex);

                visited.Add(vertex);

                if (vertexWithDepth.Item2 == maxDepth)
                    resultado.Add(vertex);

                // If the current vertex's level is greater or equals
                // the maximum desired level, skip adding its
                // adjacent vertexes.
                int vertexLevel = vertexWithDepth.Item2;
                if (vertexLevel >= maxDepth)
                    continue;

                foreach (var neighbor in graph.AdjacencyList[vertex])
                    if (!visited.Contains(neighbor))
                        queue.Enqueue(new Tuple<T, int>(neighbor, vertexLevel + 1));
            }

            return resultado;
        }

        public Func<T, IEnumerable<T>> ShortestPathFunction<T>(Graph<T> graph, T start)
        {
            var previous = new Dictionary<T, T>();

            var queue = new Queue<T>();
            queue.Enqueue(start);

            while (queue.Count > 0)
            {
                var vertex = queue.Dequeue();
                foreach (var neighbor in graph.AdjacencyList[vertex])
                {
                    if (previous.ContainsKey(neighbor))
                        continue;

                    previous[neighbor] = vertex;
                    queue.Enqueue(neighbor);
                }
            }

            Func<T, IEnumerable<T>> shortestPath = v => {
                var path = new List<T> { };

                var current = v;
                while (!current.Equals(start))
                {
                    path.Add(current);
                    current = previous[current];
                };

                path.Add(start);
                path.Reverse();

                return path;
            };

            return shortestPath;
        }
    }
}
