/* 
https://www.codewars.com/kata/duplicate-encoder/train/javascript/5c4e4f6bf3c54847022aa2ca
The goal of this exercise is to convert a string to a new string where each character in the new string is '(' if that character appears only once in the original string, or ')' if that character appears more than once in the original string. Ignore capitalization when determining if a character is a duplicate.

Examples:

"din" => "((("

"recede" => "()()()"

"Success" => ")())())"

"(( @" => "))(("

*/


function duplicateEncode(word){
    var enc = [];
    var bigWord = word.toUpperCase();
    for (var i =0; i < word.length; i++)
    {
      if (bigWord.slice(i+1).includes(bigWord[i]) || bigWord.slice(0,i).includes(bigWord[i])) { enc[i] = ")"; }
      else enc[i] = "(";
    }
    return enc.join("");
}


/* Test

Test.assertEquals(duplicateEncode("din"),"(((");
Test.assertEquals(duplicateEncode("recede"),"()()()");
Test.assertEquals(duplicateEncode("Success"),")())())","should ignore case");
Test.assertEquals(duplicateEncode("(( @"),"))((");

*/
