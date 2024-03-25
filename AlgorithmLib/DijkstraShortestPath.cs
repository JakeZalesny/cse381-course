namespace AlgorithmLib;

public static class DijkstraShortestPath
{

    public static (List<int>, List<int>) ShortestPath(Graph g, int startVertex)
    {
        // Set up the two lists for distance and pred
        List<int> distance = new List<int>();
        List<int> pred = new List<int>();
        
        // Fill them with the max values. 
        for(var i = 0; i < g.Size(); i++)
        {
            distance.Add(int.MaxValue);
            pred.Add(int.MaxValue);
        }

        // Set the starting vertex to 0 to begin loop. 
        distance[startVertex] = 0;

        PriorityQueue<int, int> priorityQueue = new PriorityQueue<int, int>();

        for (var i = 0; i < g.Size(); i++)
        {
            priorityQueue.Enqueue(i, distance[i]);
        }

        // Algorithm loop
        while (priorityQueue.Count > 0)
        {
            int smallestId = priorityQueue.Dequeue();

            // Update adjacent vertices
            foreach (Edge edge in g.Edges(smallestId))
            {
                // Define newDistance up here so that comparisons aren't as lengthy. 
                int newDistance = distance[smallestId] + edge.Weight;
                
                if (newDistance < distance[edge.DestId])
                {
                    //Adjust the new distance 
                    distance[edge.DestId] = newDistance;
                    pred[edge.DestId] = smallestId;
                    
                    priorityQueue.Clear();  // Clear the whole queue
                    
                    // Put everything back in it except for the destID
                    for (var i = 0; i < g.Size(); i++)
                    {
                        if(i != edge.DestId) 
                        {
                            priorityQueue.Enqueue(i, distance[i]);
                        }
                    }
                    // Enqueue the destID with the updated distance. 
                    priorityQueue.Enqueue(edge.DestId, newDistance);
                }
            }
        }
        
        return (distance, pred);
    } 
}