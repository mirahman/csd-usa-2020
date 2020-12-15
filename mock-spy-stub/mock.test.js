const getPhotosByAlbumID = require('./photo');
const expect = require('chai').expect;
const sinon = require('sinon');
const request = require('request');

describe('with mocking', () => {
    it('should calll photo album by id', (done) => {

        const photoData = [
            {
                "albumId": 2,
                "id": 51,
                "title": "non sunt voluptatem placeat consequuntur rem incidunt",
                "url": "https://via.placeholder.com/600/8e973b",
                "thumbnailUrl": "https://via.placeholder.com/150/8e973b"
            },
            {
                "albumId": 2,
                "id": 52,
                "title": "eveniet pariatur quia nobis reiciendis laboriosam ea",
                "url": "https://via.placeholder.com/600/121fa4",
                "thumbnailUrl": "https://via.placeholder.com/150/121fa4"
            },
            {
                "albumId": 2,
                "id": 53,
                "title": "soluta et harum aliquid officiis ab omnis consequatur",
                "url": "https://via.placeholder.com/600/6efc5f",
                "thumbnailUrl": "https://via.placeholder.com/150/6efc5f"
            },
            {
                "albumId": 2,
                "id": 54,
                "title": "ut ex quibusdam dolore mollitia",
                "url": "https://via.placeholder.com/600/aa8f2e",
                "thumbnailUrl": "https://via.placeholder.com/150/aa8f2e"
            },
            {
                "albumId": 2,
                "id": 55,
                "title": "voluptatem consequatur totam qui aut iure est vel",
                "url": "https://via.placeholder.com/600/5e04a4",
                "thumbnailUrl": "https://via.placeholder.com/150/5e04a4"
            }
        ];

        const photoMock = sinon.mock(request);

        photoMock.expects("get")
            .once()
            .withArgs('https://jsonplaceholder.typicode.com/albums/3/photos?_limit=5')
            .yields(null, null, JSON.stringify(photoData));


        getPhotosByAlbumID(3).then((photos) => {
            expect(photos.length).to.equal(3);
            photos.forEach(photo => {
                //console.log(photo);
                expect(photo).to.have.property('id');
                expect(photo).to.have.property('title');
                expect(photo).to.have.property('albumId');
            });

            photoMock.verify();
            photoMock.restore();
            done();
        }).catch(done);
    });
});


