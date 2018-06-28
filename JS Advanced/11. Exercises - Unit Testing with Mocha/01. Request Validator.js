function validateRequest(obj) {
    const validMethods = ['POST', 'GET', 'DELETE', 'CONNECT'];
    const validVersions = ['HTTP/0.9', 'HTTP/1.0', 'HTTP/1.1', 'HTTP/2.0'];
    const uriRegex = /^[A-Za-z0-9.]+$/g;
    const messageRegex = /^[^<>\\&'"]+$/g;
    
    let validate = {
        method: () => {
            if (!obj.hasOwnProperty('method')) {
                return false;
            }
            if (!validMethods.includes(obj['method'])) {
                return false;
            }
            return true;
        },
        uri: () => {
            if (!obj.hasOwnProperty('uri')) {
                return false;
            }
            if (!uriRegex.test(obj['uri']) || !obj['uri'] === '*' || obj['uri'] === '') {
                return false;
            }
            return true;
        },
        version: () => {
            if (!obj.hasOwnProperty('version')) {
                return false;
            }
            if (!validVersions.includes(obj['version'])) {
                return false;
            }
            return true;
        },
        message: () => {
            if (!obj.hasOwnProperty('message')) {
                return false;
            }
            if (!messageRegex.test(obj['message']) && obj['message'] !== '') {
                return false;
            }
            return true;
        }
    };
    for (let key in validate) {
        if (!validate[key]()) {
            let prop;
            if (key === 'uri') {
                prop = 'URI';
            } else {
                prop = key.substring(0, 1).toUpperCase() + key.substring(1);
            }
            throw new Error(`Invalid request header: Invalid ${prop}`);
        }
    }

    return obj;
}

validateRequest({
    method: 'GET',
    uri: 'svn.public.catalog',
    version: 'HTTP/1.1',
    message: ''
});