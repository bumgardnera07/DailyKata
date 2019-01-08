https://www.codewars.com/kata/57a083a57cb1f31db7000028

function powersOfTwo(n){
  var pow = [1];
  for (var i=1; i<= n; i++) {
    pow.push(2*pow[i-1]);
    };
   return pow;
}

//Test Cases:

Test.describe("Example Tests", function(){
  Test.assertSimilar(powersOfTwo(0), [1])
  Test.assertSimilar(powersOfTwo(1), [1, 2])
  Test.assertSimilar(powersOfTwo(4), [1, 2, 4, 8, 16])
})