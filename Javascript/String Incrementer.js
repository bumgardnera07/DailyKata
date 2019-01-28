
/* https://www.codewars.com/kata/54a91a4883a7de5d7800009c 


Your job is to write a function which increments a string, to create a new string. If the string already ends with a number, the number should be incremented by 1. If the string does not end with a number the number 1 should be appended to the new string.

Examples:

foo -> foo1

foobar23 -> foobar24

foo0042 -> foo0043

foo9 -> foo10

foo099 -> foo100
*/

function incrementString (strng) {
    if (strng.match(/[0-9]+$/))  {
      var num = strng.match(/[0-9]+$/);
      var length = num[0].length;
      var inc = (parseInt(num, 10) + 1).toString();
      while (inc.length < length)
            inc = "0" + inc;
      return strng.replace(/[0-9]+$/, inc);  
      }
    else return strng.concat("1"); 
  }

  /* Tests 
  
  Test.assertEquals(incrementString("foobar000"), "foobar001");
Test.assertEquals(incrementString("foo"), "foo1");
Test.assertEquals(incrementString("foobar001"), "foobar002");
Test.assertEquals(incrementString("foobar99"), "foobar100");
Test.assertEquals(incrementString("foobar099"), "foobar100");
Test.assertEquals(incrementString(""), "1");
  */
