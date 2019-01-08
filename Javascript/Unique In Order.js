https://www.codewars.com/kata/54e6533c92449cc251001667

var uniqueInOrder=function(iterable){
  var unique = [];
  if (typeof iterable === 'string') {
    iterable = iterable.split("");
    }
  for (i=0; i<iterable.length; i++) {
    if (iterable[i] != iterable[i+1]) {
      unique.push(iterable[i]);
      }
    }
    return unique;
}  

//Test Cases:

Test.assertSimilar(uniqueInOrder('AAAABBBCCDAABBB'), ['A','B','C','D','A','B'])