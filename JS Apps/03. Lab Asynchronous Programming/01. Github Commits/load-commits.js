function loadCommits() {
    let table = $('#commits');
    let username = $('#username').val();
    let repo = $('#repo').val();
    let url = `https://api.github.com/repos/${username}/${repo}/commits`

    let promise = $.ajax({
        method: "GET",
        url: url
    }).then(function (result) {
        for (let c of result) {
            table.append($(`<li>${c.commit.author.name}: ${c.commit.message}</li>`));
        }
    }).catch(function (err) {
        table.append($(`<li>Error: ${err.status} (${err.statusText})</li>`));
    });

    table.empty();
}