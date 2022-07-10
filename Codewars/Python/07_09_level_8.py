# Given an array of integers as strings and numbers, return the sum of the array values as if all were numbers.

# Return your answer as a number.
import functools

def sum_mix(arr):
    return functools.reduce(lambda a, b: int(a) + int(b), arr)