/*
https://www.codewars.com/kata/count-characters-in-your-string/train/javascript/5c505d21bb6379221ca591af

The main idea is to count all the occuring characters(UTF-8) in string. If you have string like this aba then the result should be { 'a': 2, 'b': 1 }

What if the string is empty ? Then the result should be empty object literal { }
*/

function count (strng) {  
   var out = {};
   for (var i = 0; i < strng.length; i++)
    { if (out[strng[i]])
       out[strng[i]]++;
     else 
       out[strng[i]]=1;
    }
   return out;
}

/* Test Cases

function count (strng) {  
   var out = {};
   for (var i = 0; i < strng.length; i++)
    { if (out[strng[i]])
       out[strng[i]]++;
     else 
       out[strng[i]]=1;
    }
   return out;
}
*/