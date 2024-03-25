using System.ComponentModel.Design;

namespace AlgorithmLib;

public static class HuffmanTree
{
    public class Node
    {
        public char Letter { get; set; }
        public float Count { get; set; }
        
        public Node? Left;
        public Node? Right;
    }

    public static Dictionary<char,int> Profile(String text)
    {
        // ADD CODE HERE AND FIX RETURN STATEMENT
        Dictionary<char, int> profile = new Dictionary<char, int>();
        foreach (var letter in text)
        {
            if (profile.ContainsKey(letter))
            {
                profile[letter]++; 
            }
            else
            {
                profile[letter] = 1; 
            }
        }
        return profile;
    }
    public static Node BuildTree(Dictionary<char, int> profile)
    {
        // ADD CODE HERE AND FIX RETURN STATEMENT
        AlgorithmLib.PriorityQueue<Node> q = new PriorityQueue<Node>();
        foreach (var letter in profile.Keys)
        {
            Node node = new Node();
            node.Letter = letter;
            node.Count = profile[letter];
            q.Insert(node, node.Count);
        }
        
        while(q.Size() > 1)
        {
            var x = q.Dequeue();
            var y = q.Dequeue();
            Node z = new Node();
            z.Count = x.Count + y.Count;
            z.Left = x;
            z.Right = y; 
            q.Insert(z, z.Count);
        }

        return q.Dequeue(); 
    }

    public static void _CreateEncodingMap(Node? node, string code, Dictionary<char, string> map)
    {
        if (node is null)
        {
            return; 
        }

        if (node.Left is null && node.Right is null)
        {
            if (code.Length == 0)
            {
                map[node.Letter] = "1";
                
            }
            else
            {
                map[node.Letter] = code; 
            }
        }
        else
        {
            _CreateEncodingMap(node.Left, code + "0", map);
            _CreateEncodingMap(node.Right, code + "1", map);
        }
        
    }

    public static Dictionary<char, string> CreateEncodingMap(Node root)
    {
        // ADD CODE HERE AND FIX RETURN STATEMENT
        Dictionary<char, string> map = new Dictionary<char, string>(); 
        _CreateEncodingMap(root, "", map);
        return map;
    }

    public static string Encode(string text, Dictionary<char, string> map)
    {
        // ADD CODE HERE AND FIX RETURN STATEMENT
        
        string result = "";
        foreach (var letter in text)
        {
            result += map[letter];
        }
        return result;
    }

    public static string Decode(string text, Node tree)
    {
        // ADD CODE HERE AND FIX RETURN STATEMENT
        var currNode = tree;
        var result = "";
        foreach (var value in text)
        {
            if (value == '0')
            {
                currNode = currNode.Left; 
            }
            else
            {
                currNode = currNode.Right; 
            }

            if (currNode.Left is null && currNode.Right is null)
            {
                result += currNode.Letter;
                currNode = tree; 
            }
        }
        return result;
    }
}