function makeCard(card, suit) {
    const validCards = ['2', '3', '4', '5', '6', '7', '8', '9', '10', 'J', 'Q', 'K', 'A'];
    const validSuits = {
        'S': '\u2660',
        'H': '\u2665',
        'D': '\u2666',
        'C': '\u2663'
    };

    if(validCards.indexOf(card) < 0 || !validSuits.hasOwnProperty(suit)){
        throw new Error('Invalid input!');
    }

    return {
        card,
        suit,
        toString: function () {
            return card + validSuits[suit];
        }
    }
}

console.log('' + makeCard('A', 'S'));
console.log('' + makeCard('10', 'H'));
console.log('' + makeCard('1', 'C'));