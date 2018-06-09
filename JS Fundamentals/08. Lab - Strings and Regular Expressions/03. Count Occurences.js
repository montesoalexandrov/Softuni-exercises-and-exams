function countOccurences (target, text) {
    let startIndex = 0;
    let cnt = 0;
    while(true)
    {
        let index = text.indexOf(target, startIndex);
        if (index < 0) {
            break;
        }
        else{
            startIndex = index + 1;
            cnt++;
        }
    }
    console.log(cnt);
}

countOccurences('the', 'The quick brown fox jumps over the lay dog.');
countOccurences('ma', 'Marine mammal training is the training and caring for marine life such as, dolphins, killer whales, sea lions, walruses, and other marine mammals. It is also a duty of the trainer to do mental and physical exercises to keep the animal healthy and happy.')