https://www.codewars.com/kata/581f4ac139dc423f04000b99

function transposeTwoStrings(arr){
  var brkdwn1 = arr[0].split("");
  var brkdwn2 = arr[1].split("");
  var diffCount = Math.abs(brkdwn1.length- brkdwn2.length);
  var output = "";
  if (brkdwn1.length >= brkdwn2.length) {
    for ( var i=0; i< brkdwn2.length; i++) {
      output += brkdwn1[i] + " " + brkdwn2[i] + "\n";
      }
    for (var i=0; i<diffCount; i++) {
      output += brkdwn1[brkdwn2.length + i] + "  \n";
      }
      output = output.replace(/\n$/, "");
      return output;
    }  else  {
    for ( var i=0; i< brkdwn1.length; i++) {
      output += brkdwn1[i] + " " + brkdwn2[i] + "\n";
      }
    for (var i=0; i<diffCount; i++) {
      output += "  " + brkdwn2[brkdwn1.length + i] + "\n";
      }
      output = output.replace(/\n$/, "");
      return output;
    };
  }

//Test Cases:

//basic tests
Test.describe("Basic", function(){
  Test.assertEquals(transposeTwoStrings(['Hello','World']), "H W\ne o\nl r\nl l\no d", "Should return H W\ne o\nl r\nl l\no d");
  Test.assertEquals(transposeTwoStrings(['joey','louise']), "j l\no o\ne u\ny i\n  s\n  e", "Should return j l\no o\ne u\ny i\n  s\n  e");
  Test.assertEquals(transposeTwoStrings(['a','cat']), "a c\n  a\n  t", "Should return a c\n  a\n  t");
  Test.assertEquals(transposeTwoStrings(['cat','']), "c  \na  \nt  ", "Should return c  \na  \nt  ");
  Test.assertEquals(transposeTwoStrings(['!a!a!','?b?b']), "! ?\na b\n! ?\na b\n!  ", "Should return ! ?\na b\n! ?\na b\n!  ");
})
   