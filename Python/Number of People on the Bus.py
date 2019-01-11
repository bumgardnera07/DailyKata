#https://www.codewars.com/kata/5648b12ce68d9daa6b000099

def number(bus_stops):
    riders = 0;
    for stop in bus_stops:
        riders += stop[0] - stop[1];
    return riders;

#Test Cases

test.assert_equals(number([[10,0],[3,5],[5,8]]),5)
test.assert_equals(number([[3,0],[9,1],[4,10],[12,2],[6,1],[7,10]]),17)
test.assert_equals(number([[3,0],[9,1],[4,8],[12,2],[6,1],[7,8]]),21)