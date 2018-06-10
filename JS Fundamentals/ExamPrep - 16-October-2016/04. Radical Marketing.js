function solve(input) {
    let peopleWithSubscribers = new Map();
    let personSubscribedTo = new Map();

    for (let i = 0; i < input.length; i++) {
        let currentCommand = input[i];

        if (currentCommand.indexOf('-') === -1) {
            if (peopleWithSubscribers.has(currentCommand)) {
                continue;
            }

            peopleWithSubscribers.set(currentCommand, []);
            personSubscribedTo.set(currentCommand, 0);
        } else {
            [firstPerson, secondPerson] = currentCommand.split('-');

            if(!peopleWithSubscribers.has(firstPerson) || !peopleWithSubscribers.has(secondPerson)) {
                continue;
            }

            if(firstPerson === secondPerson || peopleWithSubscribers.get(secondPerson).indexOf(firstPerson) !== -1) {
                continue;
            }

            let currentSubscribers = personSubscribedTo.get(firstPerson);
            personSubscribedTo.set(firstPerson, currentSubscribers + 1);

            peopleWithSubscribers.get(secondPerson).push(firstPerson);
        }
    }

    let desiredRow = Array.from(peopleWithSubscribers).sort((a,b) => {
        let resultCode = b[1].length - a[1].length;
        if(resultCode === 0) {
            resultCode = personSubscribedTo.get(b[0]) - personSubscribedTo.get(a[0]);
            return resultCode;
        } else {
            return resultCode;
        }
    })[0];

    console.log(desiredRow[0]);
    for (let i = 0; i < desiredRow[1].length; i++) {
        let element = desiredRow[1][i];
        console.log(`${i + 1}. ${element}`);
    }
}

solve(['A',
    'B',
    'C',
    'D',
    'A-B',
    'B-A',
    'C-A',
    'D-A',
    'A-C'
]);