https://www.codewars.com/kata/5355a811a93a501adf000ab7

var fizzBuzzCustom = function(stringOne = "Fizz", stringTwo = "Buzz", numOne = 3 , numTwo = 5) {
     var set= [];
     var holder = 0;
     for (var i=1; i<101; i++) {
       switch (true) {
       case i % numOne ==0 && i % numTwo ==0:
       set.push (stringOne + stringTwo);
       break;
       case i % numOne ==0 && i % numTwo !=0:
       set.push(stringOne);
       break;
       case i % numOne !=0 && i % numTwo ==0:
       set.push(stringTwo);
       break;
       case i % numOne !=0 && i % numTwo !=0:
       set.push(i);
       break;
       };
  };
  return set;
}

//Test Cases:

describe("Solution", function(){
  it("testing values", function(){
    Test.assertEquals(fizzBuzzCustom()[44], "FizzBuzz");
    Test.assertEquals(fizzBuzzCustom('Hey', 'There')[25], 26);
    Test.assertEquals(fizzBuzzCustom('Hey', 'There')[11], "Hey");
  });
});