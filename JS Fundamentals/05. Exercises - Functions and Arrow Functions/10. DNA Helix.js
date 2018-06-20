function helix(number) {
    let rows = Number(number);
    let sequence = 'ATCGTTAGGG';
    let currentIndex = 0;

    for (let i = 0; i < rows; i++) {
        let currentRow = i % 4;
        if (currentIndex === sequence.length) {
            currentIndex = 0;
        }
        if (currentRow === 0 || currentRow === 4) {
            console.log("**" + sequence[currentIndex++] + sequence[currentIndex++] + "**")
        } else if (currentRow === 1 || currentRow === 3) {
            console.log("*" + sequence[currentIndex++] + "--" + sequence[currentIndex++] + "*")
        } else {
            console.log(sequence[currentIndex++] + "----" + sequence[currentIndex++])
        }
    }
}

helix(4);
helix(10);