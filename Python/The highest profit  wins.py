#https://www.codewars.com/kata/the-highest-profit-wins/train/python/5c6c45dfa10fc173c10cd166

def min_max(lst):
  mini = lst[0];
  maxi = lst[0];
  for x in lst:
      if x < mini:
          mini = x;
      if x > maxi:
          maxi = x;
  return [mini, maxi];

#Test Cases

from random import randint, shuffle

def test(lst, res):
  Test.assert_equals(min_max(lst), res, "tested on " + str(lst));

Test.describe("min_max")
Test.it("should work for some examples")
test([1,2,3,4,5], [1,5])
test([2334454,5], [5, 2334454])

for i in xrange(0,20):
    r = randint(0,100)
    test([r], [r,r])