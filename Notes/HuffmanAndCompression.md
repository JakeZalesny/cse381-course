# Huffman and Compression. 
- We use Huffman Trees from CSE 280 to build these. 
- No code is a prefix of another code

T = 0; 
E = 10;
S = 11;

Those form a huffman code

### Steps: 
1. Create Profile
2. Create Huffman Trees for each individual letter. 
3. Merge the 2 smallest Huffman Trees together
4. Repeat step 3 until there is only 1 huffman tree

### Mapping: 
Base Cases: 
- Leaf: add to map 
- empty 
- tree w/ 1 node - 0 or 1

Recursive Cases: 
- Go left: mapping(node.left, code+"0", map)
- Go right: mapping(node.right, code+"1", map)