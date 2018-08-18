let result = (function solve() {
    let currentId = 'depot';
    let oldName = '';

    function depart() {
        let request = {
            url: `https://judgetests.firebaseio.com/schedule/${currentId}.json`,
            success: handleSuccess,
            error: handleError
        };

        $.ajax(request);
    }

    function arrive(stopInfo) {
        $('#info').find('span').text(`Arriving at ${oldName}`);
        $('#depart').prop('disabled', false);
        $('#arrive').prop('disabled', true);
    }

    function handleSuccess(stopInfo) {
        oldName = stopInfo['name'];
        $('#info').find('span').text(`Next stop ${oldName}`);
        currentId = stopInfo['next'];
        $('#depart').prop('disabled', true);
        $('#arrive').prop('disabled', false);
    }

    function handleError() {
        oldName = stopInfo['name'];
        $('#info').find('span').text(`Error`);
        $('#depart').prop('disabled', true);
        $('#arrive').prop('disabled', true);
    }

    return {
        depart,
        arrive
    };
})();