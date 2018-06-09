function sortArray(input) {
    input.sort((a, b) => sortByLength(a, b)).forEach(el => console.log(el));

    function sortByLength(a, b) {
        return a.length - b.length || sortByName(a, b);
    }

    function sortByName(a, b) {
        return a.toLowerCase().localeCompare(b.toLowerCase());
    }
}

sortArray(['alpha', 'beta', 'gamma']);
sortArray(['Isacc', 'Theodor', 'Jack', 'Harrison', 'George']);
sortArray(['test', 'Deny', 'omen', 'Default']);