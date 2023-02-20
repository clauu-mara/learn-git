using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTesting.Models
{
    public enum Browser // era privat enum-ul si de aceea imi genera erori la build
    {
        Chrome, 
        IE,
        Firefox,
        Safari
    }

    public class BrowserClass
    {
         public static string GetBrowserName(Browser browser)
        {
            if (browser == Browser.Firefox)
                return "firefox is opened";
            else if (browser == Browser.Chrome)
                return "chrome is opened";
            else if (browser == Browser.IE)
                return "IE is opened";
            else
                return "Safari is opened";
        }
    }
}
