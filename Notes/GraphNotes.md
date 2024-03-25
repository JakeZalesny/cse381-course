# Graphs
- Undirected Graph vs. Directed Graph
- Undirected has all arrows going in both ways. 
- Graph is just a collection of vertices and edges. 

1. Calculate teh In Degree of Vertices 
2. Push all vertices of In Deg 0 onto a stack. 
3. Pop off Vertex from the stack and put into sorted result. 
4. Reduce the In Deg for all corrected vertices. 
Push on the stack any that are now 0. 

Loop 3-4. 
