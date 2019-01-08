https://www.codewars.com/kata/568ade64cfd7a55d9300003e

def calculator(distance, bus_drive, bus_walk)
  wtm= distance/$walk 
  btm= (bus_drive/$bus) + (bus_walk/$walk)
	if wtm < 1/6r
    "Walk"
  elsif wtm > 2
  	"Bus"
  elsif btm < wtm
  	"Bus"
  else
   	"Walk"
  end
end


/Test Cases:/

Test.describe('Basic tests') do
  Test.assert_equals(calculator(5, 6, 1),"Bus","The bus should win this time!")
  Test.assert_equals(calculator(4, 5, 1),"Walk","Come on, you can walk this!")
  Test.assert_equals(calculator(5, 8, 0),"Walk","If the time is exactly the time, you should walk it!")
  Test.assert_equals(calculator(5, 4, 3),"Walk","There's no point taking the bus if it drops you in the middle of nowhere!")
  Test.assert_equals(calculator(11, 15, 2),"Bus","Don't be crazy! You'll destroy your lovely shoes!")
  Test.assert_equals(calculator(0.6, 0.4, 0),"Walk","Wow. Seriously? How lazy are you?")
  Test.assert_equals(calculator(10, 0.4, 0),"Bus","You wouldn't want to walk in this case!")
  end