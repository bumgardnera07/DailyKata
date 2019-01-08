https://www.codewars.com/kata/56747fd5cb988479af000028

def get_middle(s)
    if s.length % 2 == 0
      return s[(s.length-2)/2] + s[(s.length)/2]
    else 
      return s[((s.length)/2)]
    end
  end


/Test Cases:/

Test.describe("Basic tests") do
    Test.assert_equals(get_middle("test"),"es")
    Test.assert_equals(get_middle("testing"),"t")
    Test.assert_equals(get_middle("middle"),"dd")
    Test.assert_equals(get_middle("A"),"A")
    Test.assert_equals(get_middle("of"),"of")
    end