function extractLinks(arr) {
    let regex = /www\.[A-Za-z0-9-]+(\.[a-z]+)+/g;
    let result = [];

    for(let word of arr) {
        let match = regex.exec(word);
        while (match) {
            result.push(match[0]);
            match = regex.exec(word);
        }
    }
    console.log(result.join('\n'))
}

extractLinks(['Join WebStars now for free, at www.web-stars.com', 'You can also support our partners:',
    'Internet - www.internet.com', 'WebSpiders - www.webspiders101.com', 'Sentinel - www.sentinel.-ko']);