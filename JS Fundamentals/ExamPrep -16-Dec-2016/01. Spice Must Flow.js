function calculate(arr) {
    let totalYield = 0;
    let dayCount = 0;
    let tempYield = Number(arr[0]);

    while(tempYield >= 100) {
        totalYield += tempYield - 26;
        dayCount++;
        tempYield -= 10;
    }

    if(totalYield < 26) {
        totalYield = 0;
    } else {
        totalYield -= 26;

    }
    console.log(dayCount);
    console.log(totalYield);
}

calculate(['111']);
calculate(['450']);
calculate(['200']);