const getPhotosByAlbumID = require('./photo');
const expect = require('chai').expect;

describe('direct testing the call', () => {
    it('should calll photo album by id', (done) => {
        getPhotosByAlbumID(1).then((photos) => {
            expect(photos.length).to.equal(5);
            photos.forEach(photo => {
                //console.log(photo);
                expect(photo).to.have.property('id');
                expect(photo).to.have.property('title');
                expect(photo).to.have.property('albumId');
            });
            done();
        });
    });
});


