# Cyclic Graphing
- Basically get all the way up to the setting to infinity and looping through the edges in Acyclic Graph
- Can't go to next one in TOPO Sort, there is no sort. 

1. Go to the next good thing in the graph, you'll have to loop back and do some edges again. 

Steps from Bro. Macbeth: 

1. Set up distance & pred table to infinity and set starting distance to 0. 

2. Select the vertex with the smalles distance not yet analyzed. 

3. Relax the edges. Repeat 2-3.