https://www.codewars.com/kata/545c4f7682e55d3c6e0011a1

var findBall = function(scales, ball_count) {
	var weighCount= Math.ceil(Math.log(ball_count) / Math.log(3));
  var left = [];
  var right = [];
  var off = [];
  var ballz =  ball_count;
  var heavySet =[];
  for (var k = 0; k < weighCount; k++) {
  	if (heavySet.length == 1) {
    	return heavySet[0];
    }
    else if (heavySet.length == 2) {
    	left[0] =heavySet[0];
      right[0] =heavySet[1];
      var check = scales.getWeight(left, right);
      if (check == 1) {
        return right[0];
      } else if (check == -1) {
        return left[0];
        } else if (check == 0) {
        return 0;
        }
    }	else {
    var p= heavySet[0] || 1;
    var sets=(Math.floor(ballz/3));
    for (var i = 1; i <=sets; i++) {
    	left.push(p);
    	right.push(p+sets);
   	 	off.push(p+(2*sets));
      p++;
    }
    if (ballz%3 ==1) {
    	var special1 = heavySet[ballz-1] || ballz;
      off.push(special1);
      }
    else if (ballz%3 ==2) {
    	var last1 = heavySet[ballz-1] || ballz;
      var last2 = heavySet[ballz-2] || ballz-1;
      off.push(last2);
      off.push(last1);
      var special1 = right.shift();
      var special2 = off.shift();
      right.push(special2);
      var special2 = off.shift();
      right.push(special2);
      left.push(special1);;

      }
      //array is ready to be checked
     var check = scales.getWeight(left, right);
      
     if (check == 1) {
     	heavySet= right;
     }
     else if (check == -1) {
      heavySet= left;
     }
     else if (check == 0) {
     	heavySet= off;
     }
      var left = [];
  		var right = [];
  		var off = [];
      ballz = heavySet.length;
     }
  }
  return heavySet[0];
}
