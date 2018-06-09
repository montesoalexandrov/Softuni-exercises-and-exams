function scoreToHtml(input) {
    input = JSON.parse(input);
    let html = "<table>\n";
    html += "  <tr><th>name</th><th>score</th></tr>\n";

    for (let obj of input) {
        html += `  <tr><td>${htmlEscape(obj.name)}</td><td>${obj.score}</td></tr>\n`;
    }
    html += "</table>";

    console.log(html);

    function htmlEscape(text) {
        let map = {
            '"': '&quot;', '&': '&amp;',
            "'": '&#39;', '<': '&lt;', '>': '&gt;'
        };
        return text.replace(/[\"&'<>]/g, ch => map[ch]);
    }
}

scoreToHtml('[{"name":"Pesho","score":479},{"name":"Gosho","score":205}]');