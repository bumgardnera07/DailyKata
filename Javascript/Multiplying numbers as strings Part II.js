//https://www.codewars.com/kata/5923fbc72eafa9bcff00011a

/*

TODO
Multiply two numbers! Simple!

Rules
The arguments are passed as strings.
The numbers will be very large
The arguments can be negative, in decimals, and might have leading and trailing zeros. e.g. "-01.300"
Answer should be returned as string
The returned answer should not have leading or trailing zeroes (when applicable) e.g. "0123" and "1.100" are wrong, they should be "123" and "1.1"
Zero should not be signed and "-0.0" should be simply returned as "0".

*/

function multiply(n, o){

  var nega = n.includes("-") ? -1 : 1;
  var negb = o.includes("-") ? -1 : 1;
  var decplacea = n.includes("-") ? n.substr(1).indexOf("."):n.indexOf(".");
  var decplaceb = o.includes("-") ? o.substr(1).indexOf("."):o.indexOf(".");
  a = n.replace(/[\-.]+/g, "");
  b= o.replace(/[\-.]+/g, "");
  var digita = a.length;
  var digitb = b.length;
  var prodlength = digita + digitb;
  var product = new Array(prodlength).fill(0);
  var decindex = 50000;
  
  //elementary school multiplication, one decimal place at a time
  
  for(var i = 0; i < digita; i++) {
    for (var k = 0; k < digitb; k++) {
    var tensplace = prodlength-i-k-1;
    product[(tensplace)] += ((b.charAt(digitb-k-1))*(a.charAt(digita-i-1)));
    }
  }
  
  //carry the one
  for(var j = prodlength-1; j >=0 ; j--)
  {
    var digit = product[j];
    if (digit >= 10)
    {
      product[j-1] += ((digit - (digit % 10))/10);
    }
    product[j] = digit % 10;
  }
  
  //trim extra zeros
  for (i = product.length-1; i >= 0; i--)
  {
    if ( product[i] != 0)
      {
      var lastnum = i;
      break;
      }
  }
  
  for (i = 0; i < product.length; i++)
  {
      if ( product[i] != 0)
      {
      var firstnum = i;
      break;
      }
  }
    
  if (firstnum == null) {return "0";} 
  
  //decimal place
  if (decplacea != -1 || decplaceb != -1 )
  {
    var aplace = n.includes(".") ? digita-decplacea : 0;
    var bplace = o.includes(".") ? digitb-decplaceb : 0;
    var decindex = (prodlength-(aplace+bplace));
    product.splice(decindex, 0, '.')
  }
  
  //trims 0s and decimal if its the last character
  output = product.slice(Math.min(firstnum, decindex-1), lastnum+2)
  if (output[output.length-1] == ".") 
    output.pop();
    
  //negative?
  output[0] = output[0] * (nega * negb);
  
  return output.join(""); 
}
}

//Test Cases:

describe('Some simple multiplications', function() {
  it('simple', function() {
    Test.assertEquals(multiply("2", "3"), "6");
    Test.assertEquals(multiply("30", "69"), "2070");
    Test.assertEquals(multiply("11", "85"), "935");
  });
});

describe('Some corner test multiplications', function() {
  it('simple', function() {
    Test.assertEquals(multiply("-51268267298", "-18124.694644952680263211501188489449098237349"), "929221689752063.218295856238839321757221197469178913002");
    Test.assertEquals(multiply("-0.01", "0.0000"), "0");
    Test.assertEquals(multiply("2.01", "3.0000"), "6.03");
    Test.assertEquals(multiply("2", "-3.000001"), "-6.000002");
    Test.assertEquals(multiply("-5.0908", "-123.1"), "626.67748");
  });
});