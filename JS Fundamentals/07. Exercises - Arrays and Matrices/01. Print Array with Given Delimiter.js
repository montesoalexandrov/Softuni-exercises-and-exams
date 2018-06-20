function printArray(arr) {
    let symbol = arr[arr.length - 1];
    let result = "";

    for (let i = 0; i < arr.length - 1; i++) {
        if(i === arr.length - 2) {
            result = result + arr[i];
            break;
        }
        result = result + arr[i] + symbol;
    }
    console.log(result);
}

printArray(['One', 'Two', 'Three', 'Four', 'Five', '-']);
printArray(['How about no?', 'I', 'will', 'not', 'do', 'it!', '_'])