function decodeMessages(input) {
    let specialKey = input[0];
    let pattern = `(\\s|^)(${specialKey}\\s+)([!#$%A-Z]{8,})(\\.|,|\\s|$)`;
    let rgx = new RegExp(pattern, 'gi');

    for (let i = 1; i < input.length; i++) {
        let currentString = input[i];
        let match;
        while (match = rgx.exec(currentString)) {
            let encodedWord = match[3];
            if (encodedWord.toUpperCase() !== encodedWord) {
                continue;
            }

            let decodedWord = decodeWord(encodedWord);
            let decodedMatch = match[1] + match[2] + decodedWord + match[4];
            currentString = currentString.replace(match[0], decodedMatch);
        }

        console.log(currentString);
    }

    function decodeWord(encodedWord) {
        while (encodedWord.indexOf('!') !== -1) {
            encodedWord = encodedWord.replace('!', '1');
        }

        while (encodedWord.indexOf('%') !== -1) {
            encodedWord = encodedWord.replace('%', '2');
        }

        while (encodedWord.indexOf('#') !== -1) {
            encodedWord = encodedWord.replace('#', '3');
        }

        while (encodedWord.indexOf('$') !== -1) {
            encodedWord = encodedWord.replace('$', '4');
        }

        return encodedWord.toLowerCase();
    }
}

decodeMessages(['specialKey',
    'In this text the specialKey HELLOWORLD! is correct, but',
    'the following specialKey $HelloWorl#d and spEcIaLKEy HOLLOWORLD1 are not, while',
    'SpeCIaLkeY   SOM%%ETH$IN and SPECIALKEY ##$$##$$ are!'
])