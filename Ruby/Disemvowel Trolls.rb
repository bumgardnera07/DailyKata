https://www.codewars.com/kata/52fba66badcd10859f00097e

def disemvowel(str)
    str.split("").reject! {|i| str[i] =~ /a|e|i|o|u|A|E|I|O|U/}.join
  end

/Test Cases:/

Test.assert_equals(disemvowel("This website is for losers LOL!"),
  "Ths wbst s fr lsrs LL!")