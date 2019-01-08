https://www.codewars.com/kata/5526fc09a1bbd946250002dc

function findOutlier(integers){
  var proto = Math.abs(integers[0] % 2);
  var val1 = Math.abs(integers[1] % 2);
  var val2 = Math.abs(integers[2] % 2);
  if (proto == val1) {
    for (var i= 2; i < integers.length; i++) {
      if (Math.abs(integers[i] % 2) != proto) {
      return integers[i];
      }
    }
  }
  else if (proto != val1 && val1 == val2) {
    return integers[0];
  }
   else if (proto != val1 && proto == val2) {
    return integers[1];
  }   
}

//Test Cases:

Test.assertEquals(findOutlier([0, 1, 2]), 1)
Test.assertEquals(findOutlier([1, 2, 3]), 2)
Test.assertEquals(findOutlier([2,6,8,10,3]), 3)
Test.assertEquals(findOutlier([0,0,3,0,0]), 3)
Test.assertEquals(findOutlier([1,1,0,1,1]), 0)