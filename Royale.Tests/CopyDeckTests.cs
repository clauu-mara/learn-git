using Framework.Selenium;
using OpenQA.Selenium;

namespace Royale.Tests
{
    public class CopyDeckTests
    {
        [SetUp]
    public void BeforeEach()
    {
        Driver.Init(); //something unclear...
        Royale.Pages.Pages.Init();
        Driver.GoTo("https://statsroyale.com");
    }

    [TearDown]
    public void AfterEach()
    {
         Driver.Current.Quit();
    }
    [Test]
    public void UserCanCopyTheDeckTest()
    {
        //go to deck builder page
        Driver.Current.FindElement(By.CssSelector("[href='/deckbuilder']")).Click(); // hmmm, why only using current?
        //Click add cards manually
        Driver.Current.FindElement(By.XPath("//a[text()='add cards manually']")).Click();
        //click copy deck icon
         Driver.Current.FindElement(By.CssSelector(".copyButton")).Click();
        //click yes
         Driver.Current.FindElement(By.CssSelector("button-open")).Click();
        //assert the if click yes message is displayed
        var copyMessage= Driver.Current.FindElement(By.CssSelector(".notes.active"));
        Assert.That(copyMessage.Displayed);
    }

    }
}