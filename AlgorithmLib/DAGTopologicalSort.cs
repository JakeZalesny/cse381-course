using System.Collections;

namespace AlgorithmLib;

public static class DAGTopologicalSort
{
    public static List<int> Sort(Graph g)
    {
        // I used an array for inDegree, I'm wondering if a list would've work.
        // I know in lists you can compare using index notation (or whatever it's called)
        // but I'm not sure the adding would've worked as well...
        
        int[] inDegree = new int[g.Size()];
        List<int> linearOrder = new List<int>();
        
        //Potential error here in for loop. Might need to do a foreach 
        for(var vertex = 0; vertex < g.Size(); vertex++)
        {
            //This should go through each edge and for the matching destination add just one. 
            foreach (var edge in g.Edges(vertex))
            {
                inDegree[edge.DestId]++; 
            }
            
        }
        
        // I used a stack here because it's lifo. Might need a queue 
        Stack<int> next = new Stack<int>();
        
        //Potential error here in for loop
        for (var vertex = 0; vertex < g.Size(); vertex++)
        {
            if (inDegree[vertex] == 0)
            {
                next.Push(vertex);
            }
            
        }

        while (next.Count > 0)
        {
            //Takes out the first vertex.
            var vertex = next.Pop();
            linearOrder.Add(vertex);
            
            //Iterates through the edges of the vertex
            foreach (var edge in g.Edges(vertex))
            {
                inDegree[edge.DestId]--;
                if (inDegree[edge.DestId] == 0)
                {
                    next.Push(edge.DestId);
                }
            }
            
        }
        
        return linearOrder;
    } 
}