function getEven(arr) {
    let evenList = '';
    for (let i = 0; i < arr.length; i++) {
        if (i % 2 === 0) {
            evenList += arr[i] + ' ';
        }
    }
    console.log(evenList);
}
getEven(['20', '30', '40'])