function concatenateWords(words) {
    words = words.join('');
    console.log(Array.from(words).reverse().join(""));
}

concatenateWords(['I', 'am', 'student']);