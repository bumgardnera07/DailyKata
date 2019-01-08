https://www.codewars.com/kata/5264d2b162488dc400000001

def spinWords(string)
    p = string.split.map do |word|
      if word.length <5
        word
      else 
        word.reverse    
      end
    end
    p.join(" ")
  end

/Test Cases:/

Test.assert_equals(spinWords("Hey fellow warriors"), "Hey wollef sroirraw");