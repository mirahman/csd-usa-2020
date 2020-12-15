const request = require('request');

const getPhotosByAlbumID = (id) => {

    const requestURL = `https://jsonplaceholder.typicode.com/albums/${id}/photos?_limit=5`;
    //const requestURL = "http://google.com";

    return new Promise((resolve, reject) => {
        request.get(requestURL, (err, res, body) => {
            if (err) {
                return reject(err);
            }
            resolve(JSON.parse(body));
        });
    });

}

module.exports = getPhotosByAlbumID;
