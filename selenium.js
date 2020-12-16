const { Builder, Key, until, WebDriver, By } = require('selenium-webdriver');
const fs = require('fs');

(async function seleniumTest() {
    let webdriver = await new Builder().forBrowser('chrome').build();
    try {
        await webdriver.get('https://google.com');
        await webdriver.findElement(By.name('q')).sendKeys('ATDD', Key.RETURN);
        await webdriver.wait(until.titleIs('ATDD - Google Search'), 1000);
        await webdriver.wait(webdriver.sleep(1000));
        await webdriver.takeScreenshot().then(
            function (image, err) {
                fs.writeFile('screenshot.png', image, 'base64', function (err) {
                    if (err != null)
                        console.log('Error Occured');
                })
            }
        );
    } finally {
        await webdriver.quit();
    }

})();