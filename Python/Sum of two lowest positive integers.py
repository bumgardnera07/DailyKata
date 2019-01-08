#https://www.codewars.com/kata/558fc85d8fd1938afb000014

def sum_two_smallest_numbers(numbers):
    numbers.sort()
    return numbers[0] + numbers[1]

#Test Cases

Test.describe("Basic tests")
Test.assert_equals(sum_two_smallest_numbers([5, 8, 12, 18, 22]), 13)
Test.assert_equals(sum_two_smallest_numbers([7, 15, 12, 18, 22]), 19)
Test.assert_equals(sum_two_smallest_numbers([25, 42, 12, 18, 22]), 30)