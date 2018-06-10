function buildWall(arr) {
    let crews = [];
    let days = [];

    for (let crew of arr) {
        crews.push(Number(crew));
    }

    while (true) {
        let sumOfCrews = crews.reduce((a, b) => a + b);
        if (sumOfCrews === crews.length * 30) { // ако всички стойности са 30 излизам от цикъла.
            break;
        }

        let workingCrews = 0;

        for (let i = 0; i < crews.length; i++) {
            if (crews[i] < 30) { // проверявам всеки участък дали не е достигнал 30 фута
                crews[i] += 1;
                workingCrews++;
            }
        }

        days.push(workingCrews * 195);
    }

    let totalSum = days.reduce((a, b) => a + b) * 1900;

    console.log(days.join(", "));
    console.log(`${totalSum} pesos`);
}

buildWall([15, 15, 15, 15]);
buildWall([21, 25, 28]);
buildWall([17]);
buildWall([17, 22, 17, 19, 17]);