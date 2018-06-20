function checkString(str, subStr) {
    let startOfStr = str.substring(0, subStr.length);
    if(startOfStr === subStr) {
        console.log('true');
    } else {
        console.log('false');
    }
}

checkString('How have you been?', 'how');
checkString('The quick brown fox…', 'The quick brown fox…');
checkString('Marketing Fundamentals, starting 19/10/2016', 'Marketing Fundamentals, sta');