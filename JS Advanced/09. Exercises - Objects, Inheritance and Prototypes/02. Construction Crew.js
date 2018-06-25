function solve(obj) {
    let worker = {
        weight: obj.weight,
        experience: obj.experience,
        bloodAlcoholLevel: obj.bloodAlcoholLevel,
        handsShaking: obj.handsShaking
    };

    if(worker.handsShaking === true) {
        worker.bloodAlcoholLevel += (worker.weight * 0.1) * worker.experience;
        worker.handsShaking = false;
    }

    return worker;
}

solve({ weight: 80,
    experience: 1,
    bloodAlcoholLevel: 0,
    handsShaking: true }
);
solve({ weight: 120,
    experience: 20,
    bloodAlcoholLevel: 200,
    handsShaking: true }
);