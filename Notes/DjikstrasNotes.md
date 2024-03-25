# Djikstras Instructions

1. Create Dist & Pred tables (inf) O(V)
2. Set start vertex to zero
3. Create Priority Queue with all verticies O(V log V)
4. Loop until Queue is empty

    a. Dequeue from the Queue O(V log V)

    b. Relax all the edges of the vertex selected

    c. Update the priority aka the distance in the queue 
    O(E log v)

## Heap or Priority Queue:
- Heap is a binary tree
- Heap Property: parent <= children. 
- Insert (Enqueue) is O(log n)
- Dequeue O(1) + O(log n)

- Parent(index) = floor(index - 1/ 2)
- left(index) = 2 * index + 1
- right(index) = 2 * index + 2
- have a map that goes Vertex --> Node
- O(V log V + E log V)