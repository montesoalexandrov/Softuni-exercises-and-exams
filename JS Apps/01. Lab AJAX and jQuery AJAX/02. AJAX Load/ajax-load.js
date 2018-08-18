function loadTitle() {
    let title = $('<div>').load('text.html');
    $('#text').append(title);
}