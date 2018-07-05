function cardDeckBuilder(selector) {
    function reverse() {
        const cards = $('.card');
        $(selector).append(cards.get().reverse());
    }

    return {
        addCard(face, suit) {
            let suits = {
                C: '\u2663',
                D: '\u2666',
                H: '\u2665',
                S: '\u2660'
            };
            const element = $(`<div class="card">${face} ${suits[suit]}</div>`);
            element.click(reverse);
            element.appendTo(selector);
        }
    }
}