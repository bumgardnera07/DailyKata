https://www.codewars.com/kata/56582133c932d8239900002e

function mostFrequentItemCount(collection) {
  collection.sort(function(a, b){return a-b});
  var numCounts= [];
  var count= 1;
  var hiCount= 0;
  for (i=1; i<collection.length+1; i++) {
    if (collection[i] === collection[i-1]) {
      count++;
      }
    else {
      numCounts.push(count);
      count=1;
      }
    }
   for (j=0; j < numCounts.length; j++) {
     if (numCounts[j] > hiCount) {
     hiCount = numCounts[j];
     }
     }
     return hiCount;
  }

//Test Cases:

Test.assertEquals(mostFrequentItemCount([3, -1, -1]), 2);
Test.assertEquals(mostFrequentItemCount([3, -1, -1, -1, 2, 3, -1, 3, -1, 2, 4, 9, 3]), 5);