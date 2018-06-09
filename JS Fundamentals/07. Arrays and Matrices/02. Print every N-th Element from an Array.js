function printArray(arr) {
    let step = Number(arr[arr.length - 1]);

    for (let i = 0; i < arr.length - 1; i += step) {
        console.log(arr[i]);
    }
}

printArray(['5', '20', '31', '4', '20', '2']);
printArray(['das', 'asd', 'test', 'tset', '2']);
printArray(['1', '2', '3', '4', '5', '6']);