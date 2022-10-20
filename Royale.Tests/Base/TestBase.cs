using Framework;
using Framework.Selenium;
using NUnit.Framework.Interfaces;

namespace Tests.Base
{
    public abstract class TestBase
    {
         [OneTimeSetUp]
        public virtual void BeforeAll()
        {
            FW.SetConfig();
            FW.CreateTestResultsDirectory();
        }
        [SetUp]
        public virtual void BeforeEach()
        {
            FW.SetLogger();
            Driver.Init(); //something unclear...
            Royale.Pages.Pages.Init();
            Driver.GoTo(FW.Config.Test.Url);
        }

        [TearDown]
        public virtual void AfterEach()
        {
            var outcome = TestContext.CurrentContext.Result.Outcome.Status;
            if(outcome == TestStatus.Passed)
            {
                FW.Log.Info("Outcome:Passed");
            }
            else if (outcome ==TestStatus.Failed)
            {
                Driver.TakeScreenshot("test_failed";)
                FW.Log.Info("Outcome: Failed");
            }
            else
            {
                FW.Log.Warning("Outcome:" + outcome);
            }
            Driver.Quit();
        }
    }
}