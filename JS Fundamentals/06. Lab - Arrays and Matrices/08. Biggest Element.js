function getBiggestNum(numbers) {
    let tempBiggestNum = Number.NEGATIVE_INFINITY;
    let biggestNum = Number.NEGATIVE_INFINITY;

    function biggestInArray() {
        for (let arr of numbers) {
            tempBiggestNum = Math.max.apply(Math, arr);

            if(tempBiggestNum > biggestNum) {
                biggestNum = tempBiggestNum;
            }
        }
        console.log(biggestNum);
    }
    return biggestInArray();
}

getBiggestNum([[20, 50, 10], [8, 33, 145]]);
getBiggestNum([[3, 5, 7, 12], [-1, 4, 33, 2], [8, 3, 0, 4]]);