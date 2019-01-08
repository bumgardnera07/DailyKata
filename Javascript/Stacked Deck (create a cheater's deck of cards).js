https://www.codewars.com/kata/54285676c9cd5ead8f000c46

var StackedDeck = function(cheatCode = Math.random()) {
    if (cheatCode % 1 === 0) {
    	cheatCode = +("." + cheatCode.toString());
    }
    this.shuffleKey = cheatCode;
    this.shuffledDeck = [];
    this.makeDeck = function() {
    	this.deck = []
    	this.names = ['2', '3', '4', '5', '6', '7', '8', '9', '10', 'J', 'Q', 'K', 'A'];
			this.suits = ['h','d','c','s'];
    	for( var s = 0; s < this.suits.length; s++ ) {
        for( var n = 0; n < this.names.length; n++ ) {
            this.deck.push(this.names[n] + this.suits[s]);
        };
       };
       return this.deck;
    }
    this.shuffledDeck = this.makeDeck();
    
}
StackedDeck.prototype.shuffle = function () {
		  for (var i= (this.shuffledDeck.length - 1); i > 0; i--) {
	    		var p = Math.floor(this.shuffleKey * i);
		 			var t = this.shuffledDeck[i];
    			this.shuffledDeck[i] = this.shuffledDeck[p];
    			this.shuffledDeck[p] = t;
          }
}

//Test Cases:

//Stacked deck check
var deck1 = new StackedDeck(6);
var deck2 = new StackedDeck(6);
deck1.shuffle();
deck2.shuffle();
Test.assertSimilar(deck2.shuffledDeck, deck1.shuffledDeck);

//Random deck check
var deck1 = new StackedDeck();
var deck2 = new StackedDeck();
deck1.shuffle();
deck2.shuffle();
Test.assertNotSimilar(deck2.shuffledDeck, deck1.shuffledDeck);