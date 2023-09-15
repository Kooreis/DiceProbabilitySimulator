import random

def roll_dice(n):
    return [random.randint(1, 6) for _ in range(n)]