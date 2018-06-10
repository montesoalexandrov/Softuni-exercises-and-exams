function decodeMessage(input) {
    let templateMatrixRows = Number(input[0]);                // взимам от input-а колко реда ще бъде templateMatrix
    let templateMatrix = [];                                    //инициализирам теймплейт матрицата
    for (let i = 1; i < 1 + templateMatrixRows; i++) {
        let currentRow = input[i];                              // ==>
        templateMatrix.push(currentRow.split(' ').map(Number)); // на тия два реда взимам числата от input-а на всеки ред, и ги добавям към templateMatrix.
    }

    let encodedMatrix = [];                                     // инициализирам матрицата в която ще пазя декриптирания текст
    for (let i = 1 + templateMatrix.length; i < input.length; i++) {
        let currentRow = input[i];                              // ==>
        encodedMatrix.push(currentRow.split(' ').map(Number));  // ред по ред/масив по масив се пълни матрицата с числата, които по-късно ще се декодират, за да станат букви
    }
    
    let templateMatrixCols = templateMatrix[0].length;          //присвоявам в променлива броя на колоните в матрицата

    for (let encodedRow = 0; encodedRow < encodedMatrix.length; encodedRow += templateMatrixRows) { // върти по редовете като стъпката е дадения ред + броят на редовете на encoded-а
        for (let encodedCol = 0; encodedCol < encodedMatrix[encodedRow].length; encodedCol += templateMatrixCols) { // по колоните, а стъпката е същата реда + броят на редовете на encoded-a
            for (let templateRow = 0; templateRow < templateMatrix.length; templateRow++) {                         // върти по редовете на template-a
                for (let templateCol = 0; templateCol < templateMatrix[templateRow].length; templateCol++) {        // върти по колоните на template-a

                    let targetRow = encodedRow + templateRow;
                    let targetCol = encodedCol + templateCol;

                    if (targetCol < encodedMatrix[encodedRow].length && targetRow < encodedMatrix.length) {
                        let summedNumber = encodedMatrix[targetRow][targetCol] + templateMatrix[templateRow][templateCol];
                        summedNumber %= 27;
                        if (summedNumber === 0) {
                            encodedMatrix[targetRow][targetCol] = ' ';
                        } else {
                            encodedMatrix[targetRow][targetCol] = String.fromCharCode(summedNumber + 64);
                        }
                    }
                }
            }
        }
    }
    let output = '';
    encodedMatrix.forEach(function (element) {
        element.forEach(function (letter) {
            output += letter;
        });
    }, this);

    console.log(output);
}

decodeMessage(['2',
    '59 36',
    '82 52',
    '4 18 25 19 8',
    '4 2 8 2 18',
    '23 14 22 0 22',
    '2 17 13 19 20',
    '0 9 0 22 22']);