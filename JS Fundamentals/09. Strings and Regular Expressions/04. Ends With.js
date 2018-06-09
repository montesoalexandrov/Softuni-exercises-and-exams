function checkStr(str, subStr) {
    let endStr = str.substring(str.length - subStr.length, str.length);

    if (endStr === subStr) {
        console.log('true');
    } else {
        console.log('false');
    }
}

checkStr('This sentence ends with fun?', 'fun?');
checkStr('This is Houston, we have…', 'We have…');
checkStr('The new iPhone has no headphones jack.', 'o headphones jack.');