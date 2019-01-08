https://www.codewars.com/kata/53368a47e38700bd8300030d

def list names
    names.map! do |item|
      item[:name]
    end
    last = names.pop
    if names.length>0
      final = names.join(", ") + " & "
      return s = final + last
    end
    if last == nil
      return ""
    else
      last
    end
  end

/Test Cases:/

Test.assert_equals(list([{name: 'Bart'},{name: 'Lisa'},{name: 'Maggie'},{name: 'Homer'},{name: 'Marge'}]), 'Bart, Lisa, Maggie, Homer & Marge',
"Must work with many names")
Test.assert_equals(list([{name: 'Bart'},{name: 'Lisa'}]), 'Bart & Lisa', 
"Must work with two names")
Test.assert_equals(list([{name: 'Bart'}]), 'Bart', "Wrong output for a single name")