https://www.codewars.com/kata/56582133c932d8239900002e

def most_frequent_item_count(collection)
    collection.sort!
    i = 0
    winner = count = 0
    while i < collection.length
    count += 1
     if collection[i] != collection[i+1]
       winner = count if count > winner
       count = 0
     end
     i += 1
    end
     winner
 end

/Test Cases:/

Test.assert_equals most_frequent_item_count([3, -1, -1]), 2, "didn't work for [3, -1, -1]"
Test.assert_equals most_frequent_item_count([3, -1, -1, -1, 2, 3, -1, 3, -1, 2, 4, 9, 3]), 5, "didn't work for [3, -1, -1, -1, 2, 3, -1, 3, -1, 2, 4, 9, 3]"
Test.assert_equals most_frequent_item_count([]), 0, "didn't work for []"
Test.assert_equals most_frequent_item_count([9]), 1, "didn't work for [9]"