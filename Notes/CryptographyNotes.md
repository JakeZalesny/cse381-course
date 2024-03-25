# Cryptography
Ways of making ciphers: 

1. Substitution Cipher
2. Shift Cipher

Key terms: 
Public / Private key: Public key is the key that we have the private is the one we're trying to guess.

Example: 
x= 7 
Public key = 3

7 * 3 = 21

1/3(7 * 3)

1/3 is the multiplicative Inverse private key. 

d = multiplicative inverse 
a = public key

d * a = 1 

da mod b = 1 mod b

da mod b = 1

d => multiplicative inverse of a mod b. 

```py 
def Euclid(a, b):
    if b == 0:
        return a
    gcd = Euclid(b, a % b)
    return gcd; 
```

additions to Euclid

Euclid(6, 0) => 
    6 = i*6 + j* 0
    i = 1; j any real number: 0 works. 

```py 
def Euclid(a, b):
    if b == 0:
        return (a, 1, 0)
    (gcd, i , j) = Euclid(b, a % b)
    return(gcd, j, i - (a // b) * j)
```

for mod inverse: 

1 = ia + jb

1 mod b = (ia + jb) mod b

1 = ia mod b + jb mod b

jb mod b = 0

1 = ia mod b

if a < b then a mod b will just be a

1 = ((i mod b) * (a mod b)) mod b

1 = ((i mod b) * a) mod b

da mod b = 1

sooooo: 

d = i mod b 

# Encryption and Decryption

p = 11
q = 37 

n = p * q = 407 

r = (p - 1)(q - 1) = 360

e = gcd(e, 360) = 1
= 7

### Encrypt: 
Encrypt(x) = x^7 mod 407

Decrypt(y) = y^103 mod 407 

