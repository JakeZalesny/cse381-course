import time


INF = float('inf')

class Edge:
    def __init__(self, destId, weight):
        self.destId = destId
        self.weight = weight

class Graph:
    def __init__(self, size):
        self._graph = [ [] for _ in range(size)]
        self._labels = [ "" for _ in range(size)]

    def set_label(self, id, label):
        self._labels[id] = label

    def add_directed_edge(self, srcId, destId, weight=0):
        edge = Edge(destId, weight)
        self._graph[srcId].append(edge)

    def add_undirected_edge(self, srcId, destId, weight=0):
        self.add_directed_edge(srcId, destId, weight)
        self.add_directed_edge(destId, srcId, weight)

    def edges(self, id):
        return self._graph[id]

    def size(self):
        return len(self._graph)

    def get_label(self, id):
        return self._labels[id]


class PriorityQueue2:

    class PqNode:

        def __init__(self, value, priority):
            self.priority = priority
            self.value = value

    def __init__(self):
        self._heap = []
        self._lookup = {}

    def parent(self,index):
        return (index - 1) // 2

    def is_leaf(self,index):
        return index >= (len(self._heap) // 2)

    def left(self,index):
        return 2 * index + 1

    def right(self,index):
        return 2 * index + 2

    def bubble_up(self, currNode):
        while currNode > 0:
            parentNode = self.parent(currNode)
            if self._heap[parentNode].priority > self._heap[currNode].priority:
                self._heap[parentNode], self._heap[currNode] = self._heap[currNode], self._heap[parentNode]
                self._lookup[self._heap[currNode].value] = currNode
                self._lookup[self._heap[parentNode].value] = parentNode
            currNode = parentNode

    def bubble_down(self, currNode):
        while not self.is_leaf(currNode):
            leftNode = self.left(currNode)
            rightNode = self.right(currNode)
            if (rightNode >= len(self._heap)) or (self._heap[leftNode].priority <= self._heap[rightNode].priority):
                if self._heap[currNode].priority > self._heap[leftNode].priority:
                    self._heap[currNode], self._heap[leftNode] = self._heap[leftNode], self._heap[currNode]
                    self._lookup[self._heap[currNode].value] = currNode
                    self._lookup[self._heap[leftNode].value] = leftNode
                currNode = leftNode
            else:
                if self._heap[currNode].priority > self._heap[rightNode].priority:
                    self._heap[currNode], self._heap[rightNode] = self._heap[rightNode], self._heap[currNode]
                    self._lookup[self._heap[currNode].value] = currNode
                    self._lookup[self._heap[rightNode].value] = rightNode
                currNode = rightNode


    def decrease_key(self, value, priority):
        curr = self._lookup[value]
        self._heap[curr].priority = priority
        self.bubble_up(curr)

    def insert(self, value, priority):
        newNode = PriorityQueue2.PqNode(value, priority)
        self._heap.append(newNode)
        curr = len(self._heap) - 1
        self._lookup[value] = curr;
        self.bubble_up(curr)

    def dequeue(self):
        if len(self._heap) == 0:
            raise Exception("Priority Queue was empty")

        result = self._heap[0]
        last = self._heap[len(self._heap)-1]
        self._heap[0] = last
        self._lookup[self._heap[0].value] = 0
        self._heap.pop()
        self._lookup.pop(result.value)
        self.bubble_down(0)

        return result.value

    def size(self):
        return len(self._heap)

    def print_heap(self):
        for pair in self._heap:
            print(f"{pair.value} (p{pair.priority}), ", end="")
        print()

# heap = PriorityQueue2()
# heap.insert("A",7);
# heap.print_heap();
# heap.insert("B",6);
# heap.print_heap();
# heap.insert("C",4);
# heap.print_heap();
# heap.insert("D",8);
# heap.print_heap();
# heap.insert("E",3);
# heap.print_heap();
# heap.insert("F",2);
# heap.print_heap();
# print("-----");
# heap.decrease_key("D",0);
# heap.print_heap();
# heap.decrease_key("C",1);
# heap.print_heap();
# print("-----");
# heap.dequeue();
# heap.print_heap();
# heap.dequeue();
# heap.print_heap();
# heap.dequeue();
# heap.print_heap();
# heap.dequeue();
# heap.print_heap();
# heap.dequeue();
# heap.print_heap();
# heap.dequeue();
# heap.print_heap();
        

# CSE 381 REPL 6D
# Dijkstra Shortest Path

# Source: https://users.cs.utah.edu/~lifeifei/SpatialDataset.htm
# Note that distance is not miles but distance measured on the map

# Shortest path using a list - O(V^2 + E)
def shortest_path1(graph, start_vertex):
    distance = [INF] * graph.size()
    pred = [INF] * graph.size()
    distance[start_vertex] = 0

    queue = [x for x in range(graph.size())]

    while len(queue) > 0:

        smallest_index = 0
        for index in range(len(queue)):
            if distance[queue[index]] < distance[queue[smallest_index]]:
                smallest_index = index
        smallest_id = queue[smallest_index]
        del queue[smallest_index]

        for edge in graph.edges(smallest_id):
            if distance[smallest_id] + edge.weight < distance[edge.destId]:
                distance[edge.destId] = distance[smallest_id] + edge.weight
                pred[edge.destId] = smallest_id;

    return (distance,pred)

# Shortest Path using a Priority Queue / Heap - O(V log V + E log V)
def shortest_path2(graph, start_vertex):
    distance = [INF] * graph.size()
    pred = [INF] * graph.size()
    distance[start_vertex] = 0

    queue = PriorityQueue2()
    for index in range(graph.size()):
        queue.insert(index, distance[index])

    while queue.size() > 0:

        smallest_id = queue.dequeue()
        for edge in graph.edges(smallest_id):
               if distance[smallest_id] + edge.weight < distance[edge.destId]:
                distance[edge.destId] = distance[smallest_id] + edge.weight
                pred[edge.destId] = smallest_id;
                queue.decrease_key(edge.destId, distance[edge.destId])

    return (distance,pred)

### PART 1 ###

print("Generating Graph")
with open("ca_roads_verticies.txt") as f:
  verticies = f.readlines() 

g = Graph(len(verticies))

with open("ca_roads_edges.txt") as f:
  for line in f:
    fields = line.strip().split(" ")
    src_id = int(fields[1])
    dst_id = int(fields[2])
    distance = float(fields[3])
    g.add_undirected_edge(src_id, dst_id, distance)

print(f"Verticies = {g.size()} Edges = {2 * len(verticies)}")


### PART 2 ###

print("Shortest Path - List Method")
start = time.perf_counter()
dist, pred = shortest_path1(g, 0)
stop = time.perf_counter()
total_time = stop - start
print(f"Total Time = {total_time}")

print("Shortest Path - Priority Queue Method")
start = time.perf_counter()
dist, pred = shortest_path2(g, 0)
stop = time.perf_counter()
total_time = stop - start
print(f"Total Time 2 = {total_time}")

### PART 3 ###
print("Finding Longest 'Shortest' Distance")


### PART 4 ### 
print("Finding Longest 'Shortest' Path")

