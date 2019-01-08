https://www.codewars.com/kata/54d472e98776e4eb5b000215

function pitchClass(note){
  var noteValue = 0;
  var noteTypes= {C:0, D:2, E:4, F:5, G:7, A:9, B:11}
  note = note.split("", 2)
  noteValue = noteTypes[note[0].toUpperCase()]
  if (noteValue == undefined) {
  	return null;
    }
  if (note[1] == "#") {
  	noteValue++;
    }
  else if (note[1] == "b") {
  	noteValue--;
    } 
  else if (note[1] != undefined) {
  return null;
  }
  
  if (noteValue <0) {
  	noteValue =11;
  }
  else if (noteValue >11) {
  	noteValue = 0;
  }
  
 	return noteValue;
}

//Test Cases:

describe( 'Example Test Cases', function(){
  it( 'should convert plain letters', function(){
    Test.assertEquals( pitchClass('D'), 2, 'D' )
  } ),

  it( 'should convert sharps', function(){
    Test.assertEquals( pitchClass('D#'), 3, 'D#' )
  } ),

  it( 'should convert flats', function(){
    Test.assertEquals( pitchClass('Ab'), 8, 'Ab' )
  } )
} );