import numpy as np

def read_input():
    with open('../Inputs/01.txt', 'r') as f:
        return np.array(f.read().split('\n'), dtype='int')

def part_01(x): 
    # Number of increases 
    return np.sum((x[1:] - x[0:-1]) > 0)

def part_02(x): 
    # Number of increases of 3 element rolling window 
    return part_01(np.convolve(x, np.ones(3), 'valid'))

x = read_input()

print(part_01(x))
print(part_02(x))