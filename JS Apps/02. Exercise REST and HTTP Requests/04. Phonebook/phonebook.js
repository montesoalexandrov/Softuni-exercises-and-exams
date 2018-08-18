function attachEvents() {
    $('#btnLoad').on('click', load);
    $('#btnCreate').on('click', create);
    let list = $('#phonebook');

    function create() {
        let data = {
            "person": $('#person').val(),
            "phone": $('#phone').val()
        };

        let req = {
            url: 'https://phonebook-f5aad.firebaseio.com/phonebook.json',
            method: 'POST',
            data: JSON.stringify(data),
            success: () => {
                $('#person').val('');
                $('#phone').val('');
                load();
            },
        };

        $.ajax(req);
    }

    function load() {
        let req = {
            url: 'https://phonebook-f5aad.firebaseio.com/phonebook.json',
            success: refresh
        };

        $.ajax(req)
    }

    function refresh(res) {
        list.empty();
        for (let contact in res) {
            let html = $(`<li>${res[contact].person}: ${res[contact].phone}</li>`);
            html.append($('<button>[Delete]</button>').click(() => deleteContact(contact)));
            list.append(html);
        }
    }

    function deleteContact(contact) {
        let req = {
            url: `https://phonebook-f5aad.firebaseio.com/phonebook/${contact}.json`,
            method: 'DELETE',
            success: load,
        };

        $.ajax(req);
    }
}