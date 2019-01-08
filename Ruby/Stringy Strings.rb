https://www.codewars.com/kata/stringy-strings/train/ruby/599893f7755eae6fc1000026

def stringy(size)
	mod = size % 2
  string = "10"*(size/2)
  if mod == 0 then return string else return (string + "1") end
end


/Test Cases:/

describe "Example Tests" do
  it "Should be a string" do
    Test.assert_equals(stringy(5).is_a?(String), true, "stringy() should return a string")
  end
  
  it "Should start with '1'" do
    Test.assert_equals(stringy(10)[0],'1',"Whoops your string doesn't start with a '1'")
  end
  
  it "Should have the correct length" do
    1.upto(5).each do |i|
      Test.assert_equals(stringy(i).length,i,"Make sure your string is the right length")
    end
  end
  
  it "Should work for some simple tests" do
    Test.assert_equals(stringy(3), '101', 'Wrong result when size is 3')
    Test.assert_equals(stringy(5), '10101', 'Wrong result when size is 5')
    Test.assert_equals(stringy(12), '101010101010', 'Wrong result when size is 12')
    Test.assert_equals(stringy(26), '10101010101010101010101010', 'Wrong result when size is 26')
    Test.assert_equals(stringy(28), '1010101010101010101010101010', 'Wrong result when size is 28')
  end
end