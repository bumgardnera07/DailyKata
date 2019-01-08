https://www.codewars.com/kata/5390bac347d09b7da40006f6

String.prototype.toJadenCase = function () {
  return (this.replace(/(^|\s)[a-z]/g,function(f){return f.toUpperCase();}));
};

//Test Cases:

var str = "How can mirrors be real if our eyes aren't real";
Test.assertEquals(str.toJadenCase(), "How Can Mirrors Be Real If Our Eyes Aren't Real");
