function makeSequence(n, k) {
    let seq = [1];
    let sum = 0;

    while (true) {
        if (seq.length === n) {
            break;
        }

        if (seq.length <= k) {
            for (let num of seq) {
                sum += num;
            }
        } else {
            for (let i = seq.length - 1; i >= seq.length - k; i--) {
                sum += seq[i];
            }
        }
        seq.push(sum);
        sum = 0;
    }
    console.log(seq);
}

makeSequence(6, 3)
makeSequence(8, 2)