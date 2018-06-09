function formFiller (n, e, num, textArr) {
    let name = n;
    let email = e;
    let telNum = num;
    let patternName = /<![a-zA-Z]+!>/g;
    let patternEmail = /<@[a-zA-Z]+@>/g;
    let patternTel = /<\+[a-zA-Z]+\+>/g;

    textArr.forEach(line => {
        line = line.replace(patternName, name);
        line = line.replace(patternEmail, email);
        line = line.replace(patternTel, telNum);
        console.log(line)});
}