const date = require('./date');

describe('date', () => {
    it('should convert 12/31/2014 correctly', () => {
        expect(date.formatDate('12/31/2014')).toEqual('20141231');
    });

    it('should convert 2/3/2014 correctly', () => {
        expect(date.formatDate('2/3/2014')).toEqual('20140203');
    });
});