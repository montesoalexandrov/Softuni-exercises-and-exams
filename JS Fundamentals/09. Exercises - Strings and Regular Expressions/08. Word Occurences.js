function wordCounter(text, word) {
    let count = 0;
    let regex = new RegExp("\\b"+word+"\\b", "gi");
    let match = regex.exec(text);

    while(match) {
        count++;
        match = regex.exec(text);
    }

    console.log(count)
}

wordCounter('The waterfall was so high, that the child couldn’t see its peak.', 'the');
wordCounter('How do you plan on achieving that? How? How can you even think of that?', 'how');
wordCounter('There was one. Therefore I bought it. I wouldn’t buy it otherwise.', 'there');