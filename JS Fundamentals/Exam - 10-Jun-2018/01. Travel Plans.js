function solve(arr) {
    let sum = 0;
    let specializedCount = 0;
    let specializedSum = 0;
    let clumsyCount = 0;

    for (let line of arr) {
        let tokens = line.split(' : ');
        let profession = tokens[0];
        let gold = Number(tokens[1]);

        if (profession === 'Programming' || profession === 'Hardware maintenance' || profession === 'Cooking'
            || profession === 'Translating' || profession === 'Designing') {
            if (gold < 200) {
                continue;
            }

            specializedCount++;
            specializedSum += gold;

            if (specializedCount % 2 === 0) {
                sum += 200;
            }
            sum += gold;
        } else if (profession === 'Singing' || profession === 'Accounting' || profession === 'Teaching'
            || profession === 'Exam-Making' || profession === 'Acting' || profession === 'Writing'
            || profession === 'Lecturing' || profession === 'Modeling' || profession === 'Nursing') {
            clumsyCount++;
            if (clumsyCount % 2 === 0) {
                sum += gold - gold * 0.05;
            } else if (clumsyCount % 3 === 0) {
                sum += gold - gold * 0.10;
            } else {
                sum += gold;
            }
        } else {
            sum += gold;
        }
    }

    sum -= specializedSum * 0.20;

    console.log(`Final sum: ${parseFloat(sum).toFixed(2)}`);
    if (sum < 1000) {
        console.log(`Mariyka need to earn ${parseFloat(Math.abs(1000 - sum))
            .toFixed(2)} gold more to continue in the next task.`)
    } else {
        console.log(`Mariyka earned ${parseFloat(Math.abs(1000 - sum)).toFixed(2)} gold more.`)
    }
}