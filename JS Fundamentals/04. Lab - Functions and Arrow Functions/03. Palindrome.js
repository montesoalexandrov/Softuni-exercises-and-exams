function isPalindrome(word) {
    let bool = true;
    for(let i = 1; i <= word.length / 2; i++) {
        if(word[i] !== word[word.length - 1 - i]) {
            bool = false;
        }
    }
    console.log(bool)
}
isPalindrome('ebisiputkatamaichina')