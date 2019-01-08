https://www.codewars.com/kata/5202ef17a402dd033c000009

def title_case(title, minor_words = nil)
    reg= minor_words.split(" ").join("|") unless minor_words==nil
    title.gsub(/\w+/, &:capitalize).gsub(/#{reg}/i, &:downcase).gsub(/^\w+/i, &:capitalize)
  end

/Test Cases:/

Test.assert_equals(title_case('a clash of KINGS', 'a an the of'), 'A Clash of Kings')
Test.assert_equals(title_case('THE WIND IN THE WILLOWS', 'The In'), 'The Wind in the Willows')

