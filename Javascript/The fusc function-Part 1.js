https://www.codewars.com/kata/570409d3d80ec699af001bf9

function fusc(n){
  if (n ==0) { return 0}
  else if (n==1) { return 1}
  else if (n%2==0) { return fusc(n/2)}
  else if (n%2==1) { return fusc((n-1)/2) + fusc(((n-1)/2)+1)}
  
}

//Test Cases:

Test.describe("The fusc function -- part 1", function() {
  Test.describe("Example tests", function() {
    Test.assertEquals(fusc(0), 0) 
    Test.assertEquals(fusc(1), 1)
    Test.assertEquals(fusc(85), 21)
  
    let solutions = [0, 1, 1, 2, 1, 3, 2, 3, 1, 4, 3, 5, 2, 5, 3, 4, 1, 5, 4, 7, 3];
    for(let i=0; i<solutions.length; i++){
    	Test.assertEquals(fusc(i), solutions[i]);
    }
  });
});