using EnumsNET;
using System.ComponentModel;

namespace AutomationTesting.Models
{
    public enum Browser // should be public
    {
        Chrome, 
        IE,
        Firefox,
        Safari,
        [Description("Internet Explorer")]
        InternetExplorer
    }

    public class BrowserClass
    {
        public static string GetBrowserName(Browser browser)
        {
            var description = (browser).AsString(EnumFormat.Description);

            if (browser == Browser.Firefox)
                return "firefox is opened";
            else if (browser == Browser.Chrome)
                return "chrome is opened";
            else if (browser == Browser.IE)
                return "IE is opened";
            else if (browser == Browser.InternetExplorer)
                return description;
            else
                return "Safari is opened";

        }
    }
}
