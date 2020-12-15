const getPhotosByAlbumID = require('./photo');
const expect = require('chai').expect;
const sinon = require('sinon');
const request = require('request');

describe('lets use spy', () => {
    let photoSpy;
    before(() => {
        photoSpy = sinon.spy(request, 'get');
    });

    after(() => {
        request.get.restore();
    });

    it('should calll photo album by id', (done) => {
        getPhotosByAlbumID(3).then((photos) => {
            expect(photoSpy.calledOnce);
            expect(photoSpy.args[0][0]).to.equal('https://jsonplaceholder.typicode.com/albums/3/photos?_limit=5');
            expect(photos.length).to.equal(5);
            photos.forEach(photo => {
                //console.log(photo);
                expect(photo).to.have.property('id');
                expect(photo).to.have.property('title');
                expect(photo).to.have.property('albumId');
            });
            done();
        }).catch(done);;
    });
});


