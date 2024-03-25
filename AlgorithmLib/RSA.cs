using System.Numerics;
using System.Runtime;

namespace AlgorithmLib;

public class RSA
{
    private static (BigInteger, BigInteger, BigInteger) Euclid(BigInteger a, BigInteger b)
    {
        // Implement Euclid here: 
        if (b == 0)
        {
            // If b is zero than the j will be 1
            return (a, 1, 0);
        }
        
        // This is the recursion, it will get the GCD i, and j until it can't go any further. 
        (var gcd, var i, var j) = Euclid(b, a % b);
        return (gcd, j, i - (a / b) * j);
    }

    private static BigInteger ModularExponentiation(BigInteger x, BigInteger y, BigInteger n)
    {
        // if the y is 0 then the modular expo will be one
        if (y == 0)
        {
            return 1; 
        }

        if (y % 2 == 0)
        {
            // if it's even keep going down. 
            var z = ModularExponentiation(x, y / 2, n);
            return (z * z) % n;
        }

        else
        {
            // If it isn't even handle this case here
            var z = ModularExponentiation(x, (y - 1) / 2, n);
            return (z * z * x) % n;
        }
    }

    public static BigInteger GeneratePrivateKey(BigInteger p, BigInteger q, BigInteger e) 
    {
        // Generate the private key using Euclidian math. 
        var r = (p - 1) * (q - 1);
        (var gcd, var i, var _) = Euclid(e, r);
        if (i < 0)
        {
            i += r;
        }
        return i % r;
    }

    public static BigInteger Encrypt(BigInteger value, BigInteger e, BigInteger n)
    {
        // Encrypt using modular exponentiation. 
        
        return ModularExponentiation(value, e, n);
    }

    public static BigInteger Decrypt(BigInteger value, BigInteger d, BigInteger n)
    {
        // Decrypt using that same modular exponentiation. 
        return ModularExponentiation(value, d, n);
    }


}