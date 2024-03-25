namespace AlgorithmLib;

public static class BellmanFordShortestPath
{
    public static (List<int>, List<int>) ShortestPath(Graph g, int startVertex)
    {
        // ADD CODE HERE AND FIX RETURN STATEMENT
        List<int> distance = new List<int>();
        List<int> pred = new List<int>();

        for (var i = 0; i < g.Size(); i++)
        {
            distance.Add(int.MaxValue);
            pred.Add(int.MaxValue);
        }

        distance[startVertex] = 0;

        // Iterate n-1 times for Dijkstra's algorithm
        for (var i = 0; i < g.Size() - 1; i++)
        {
            bool changesMade = false;
            for (var node = 0; node < g.Size(); node++)
            {
                // Iterate through g.Edges(node) instead of i
                foreach (var edge in g.Edges(node))
                {
                    if (distance[node] + edge.Weight < distance[edge.DestId])
                    {
                        // If you iterate 1 less times than the outer loop, you've hit a negative cycle.
                        if (i == g.Size() - 2)
                        {
                            return (new List<int>(), new List<int>());
                        }
                        distance[edge.DestId] = distance[node] + edge.Weight;
                        pred[edge.DestId] = node;
                        changesMade = true;
                    }
                }
            }

            if (!changesMade)
            {
                break;
            }
        }

        return (distance, pred);
        

    }
    
}