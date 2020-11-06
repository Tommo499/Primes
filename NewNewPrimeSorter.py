import math
print(">>>", end=' ')
limit = int(input('')) + 1
P = False
primes = 1
print("Prime: 2")
for i in range(3, limit):
    for f in range(2, math.ceil(math.sqrt(i)) + 1):
        P = False
        if i % f == 0:
            print("Composite: " + str(i))
            P = True
            break
    if not P:
        print("Prime: " + str(i))
        primes += 1
print(primes)
