import math


def prime(number):
    if number == 2: return True
    if number == 1 or number == 0: return False
    for f in range(2, math.ceil(math.sqrt(number)) + 1):
        P = True
        if number % f == 0:
            P = False
            break

    return P
