#https://www.codewars.com/kata/find-the-middle-element/train/python/5c6db384d2c649204cdf73b4
#As a part of this Kata, you need to create a function that when provided with a triplet, returns the index of the numerical element that lies between the other two elements.
#The input to the function will be an array of three distinct numbers (Haskell: a tuple).
#For example:
#gimme([2, 3, 1]) => 0
#2 is the number that fits between 1 and 3 and the index of 2 in the input array is 0.
#
#Another example (just to make sure it is clear):
#
#gimme([5, 10, 14]) => 1
#10 is the number that fits between 5 and 14 and the index of 10 in the input array is 1.

def gimme(numbers):
  middle = sorted(numbers); 
  return numbers.index(middle[1]);

#Test Cases

test.assert_equals(gimme([2, 3, 1]), 0, 'Finds the index of middle element')
test.assert_equals(gimme([5, 10, 14]), 1, 'Finds the index of middle element')