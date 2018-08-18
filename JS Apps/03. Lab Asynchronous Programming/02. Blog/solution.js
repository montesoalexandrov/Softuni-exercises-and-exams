function attachEvents() {
    const URL = 'https://baas.kinvey.com/appdata/kid_rkhAYhKBX/';
    const USERNAME = `peter`;
    const PASSWORD = `p`;
    const BASE_64 = btoa(USERNAME + ":" + PASSWORD);
    const AUTH = {"Authorization": "Basic " + BASE_64};
    const SELECT = $('#posts');
    const TITLE = $('#post-title');
    const BODY = $('#post-body');
    const COMMENTS = $('#post-comments')

    $('#btnLoadPosts').on('click', loadPosts);
    $('#btnViewPost').on('click', viewPosts);

    function loadPosts() {
        $.ajax({
            method: "GET",
            url: URL + 'posts',
            headers: AUTH
        }).then(function (res) {
            for (let post of res) {
                SELECT.append($(`<option id="${post._id}" body="${post.body}">${post.title}</option>`));
            }
        }).catch(function (err) {
            console.log(err);
        })
    }

    function viewPosts() {
        BODY.empty();
        COMMENTS.empty();
        let selectedElement = SELECT.find(":selected");
        let value = selectedElement.text();
        let body = selectedElement.attr('body');
        let id = selectedElement.attr("id");

        TITLE.text(value);
        BODY.append(`<li>${body}</li>`);

        $.ajax({
            method: "GET",
            url: URL + `comments/?query={"post_id":"${id}"}`,
            headers: AUTH
        }).then(function (res) {
            for (let comment of res) {
                COMMENTS.append(`<li>${comment.text}</li>`);
            }
        }).catch(function (err) {
            console.log(err);
        })
    }
}