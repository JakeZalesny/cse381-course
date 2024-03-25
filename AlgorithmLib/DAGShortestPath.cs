using System.Runtime.CompilerServices;

namespace AlgorithmLib;


public static class DAGShortestPath
{
    public static (List<int>, List<int>) ShortestPath(Graph g, int startVertex)
    {
        // This is where I initialized all of the lists I'd need. 
        var sorted = DAGTopologicalSort.Sort(g);
        
        // I made sure to set the capacity to the Graph size, otherwise
        // I'd get an index out of bounds error. 
        List<int> distance = new List<int>(g.Size());
        List<int> pred = new List<int>(g.Size());
        
        // I added in the int.MaxValue to denote infinity. 
        for (int i = 0; i < g.Size(); i++)
        {
            distance.Add(int.MaxValue); 
        }

        for (int i = 0; i < g.Size(); i++)
        {
            pred.Add(int.MaxValue); 
        }
        
        //I did this after the for loops because if I did it before I 
        //had a feeling it would be overwritten and wouldn't stay as 0
        distance[startVertex] = 0;
        
        //Relaxing edges. 
        foreach (var vertex in sorted)
        {
            if (distance[vertex] != int.MaxValue)
            {
                foreach (var edge in g.Edges(vertex))
                {
                    if (distance[vertex] + edge.Weight < distance[edge.DestId])
                    {
                        distance[edge.DestId] = distance[vertex] + edge.Weight;
                        pred[edge.DestId] = vertex; 
                    }
                }
            }            
        }
        
        return (distance, pred);
    } 
    
}