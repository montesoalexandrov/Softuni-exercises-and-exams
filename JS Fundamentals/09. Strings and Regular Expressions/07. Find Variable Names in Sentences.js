function findVariableNames(str) {
    let result = [];
    let regex = /\b_[a-zA-Z0-9]+\b/g;

    for(let word of str.split(' ')) {
        let match = regex.exec(word);
        while (match) {
            result.push(match[0].substr(1));
            match = regex.exec(word);
        }
    }
    console.log(result.join(','))
}

findVariableNames('The _id and _age variables are both integers.');
findVariableNames('Calculate the _area of the _perfectRectangle object.');
findVariableNames('__invalidVariable _evenMoreInvalidVariable_ _validVariable');