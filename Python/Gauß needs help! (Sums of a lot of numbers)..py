#https://www.codewars.com/kata/find-the-middle-element/train/python/5c6db384d2c649204cdf73b4https://www.codewars.com/kata/gauss-needs-help-sums-of-a-lot-of-numbers/train/python/5c6f0784abcd163fcc174afa

#Due to another of his misbehaved, the primary school's teacher of the young Gauß, Herr J.G. Büttner, to keep the bored and unruly young schoolboy Karl Friedrich Gauss busy for a good long time, while he teaching arithmetic to his mates, assigned him the problem of adding up all the whole numbers from 1 through a given number n.
#
#Your task is to help the young Carl Friedrich to solve this problem as quickly as you can; so, he can astonish his teacher and rescue his recreation interval.
#
#Here's, an example:
#
#f(n=100) // returns 5050
#It's your duty to verify that n is a valid positive integer number. If not, please, return false (None for Python, null for C#).
#
#Note: the goal of this kata is to invite you to think about some 'basic' mathematic formula and how you can do performance optimization on your code.
#
#Advanced - experienced users should try to solve it in one line, without loops, or optimizing the code as much as they can.

def f(n):
    return n*(n+1)/2 if (isinstance(n, int) and n > 0) else None

#Test Cases

test.assert_equals(f(1), 1)
test.assert_equals(f(100), 5050)