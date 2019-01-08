https://www.codewars.com/kata/5497a3c181dd7291ce000700

def diagonalSum(matrix)
	address = sum = 0
  (sum += matrix[address][address]; address += 1) until address == matrix.length
  return sum
end

/Test Cases/

Test.assert_equals(diagonal_sum([
    [1, 2, 3],
    [4, 5, 6],
    [7, 8, 9] ]), 15)

Test.assert_equals(diagonal_sum([
    [1, 2],
    [3, 4] ]), 5)

Test.assert_equals(diagonal_sum([
    [ 1,  2,  3,  4],
    [ 5,  6,  7,  8],
    [ 9, 10, 11, 12],
    [13, 14, 15, 16] ]), 34)