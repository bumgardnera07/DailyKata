https://www.codewars.com/kata/5513795bd3fafb56c200049e

def count_by(x, n)
  i = 1
  sol = []
  while i <= n
  	sol.push(i*x)
    i += 1
   end
   return sol
end

/Test Cases:/

Test.assert_equals(count_by(1, 5), [1, 2, 3, 4, 5])
Test.assert_equals(count_by(2, 5), [2, 4, 6, 8, 10])
Test.assert_equals(count_by(3, 5), [3, 6, 9, 12, 15])
Test.assert_equals(count_by(50, 5), [50, 100, 150, 200, 250])
Test.assert_equals(count_by(100, 5), [100, 200, 300, 400, 500])