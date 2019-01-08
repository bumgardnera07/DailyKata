https://www.codewars.com/kata/538ae2eb7a4ba8c99b000439

def autocorrect(input)
    n = input.gsub(/\byou+\b/i, 'your sister')  
    n.gsub(/\bu\b/i, 'your sister')
  end
/Test Cases:/
describe ".autocorrect" do
    it "change 'u' or 'you' to 'your sister'" do
      Test.assert_equals(autocorrect("u"), "your sister")
      Test.assert_equals(autocorrect("you"), "your sister")
      Test.assert_equals(autocorrect("hello there"), "hello there")
      Test.assert_equals(autocorrect("random string"), "random string")
      Test.assert_equals(autocorrect("I miss you!"), "I miss your sister!")
    end
  end