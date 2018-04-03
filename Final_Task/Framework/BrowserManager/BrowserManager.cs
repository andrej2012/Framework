using NLog;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System.Configuration;

namespace Framework.BrowserManager
{
    public sealed class Singleton
    {
        //private static readonly Lazy<Singleton> instanceHolder =
            //new Lazy<Singleton>(() => new Singleton());
        public IWebDriver Browser;
        public BrowserManagers Choose = new BrowserManagers();

        public Singleton()
    {
        this.Browser = Choose.ChooseBrowser();
    }

        /*public static Singleton Instance
        {
            get { return instanceHolder.Value; }
        }*/
    }
    public class BrowserManagers
    {
        NLog.Logger logger = LogManager.GetCurrentClassLogger();
        public string selector = ConfigurationManager.AppSettings["language"];
        public string browser = ConfigurationManager.AppSettings["browser"];
        public string path = ConfigurationManager.AppSettings["path"];
        public IWebDriver ChooseBrowser()
        {
            IWebDriver Browser;
            if (browser == "Chrome")
            {
                logger.Debug("Choose Browser Chrome");
                var chromeOptions = new ChromeOptions();
                chromeOptions.AddArguments("-lang=en");
                chromeOptions.AddUserProfilePreference("safebrowsing.enabled", "true");
                chromeOptions.AddUserProfilePreference("profile.default_content_settings.popups", "0");
                chromeOptions.AddUserProfilePreference("disable-popup-blocking", "true");
                Browser = new ChromeDriver(chromeOptions);
                return Browser;
            }

            if (browser == "FireFox")
            {
                logger.Debug("Choose Browser FireFox");
                var profile = new FirefoxProfile();
                profile.SetPreference("intl.accept_languages", "en");
                profile.SetPreference("browser.download.folderList", 2);
                profile.SetPreference("browser.download.manager.alertOnEXEOpen", false);
                profile.SetPreference("browser.helperApps.neverAsk.saveToDisk", "application/octet-stream, application/x-debian-package");
                profile.SetPreference("browser.download.manager.focusWhenStarting", false);
                profile.SetPreference("browser.download.useDownloadDir", true);
                profile.SetPreference("browser.helperApps.alwaysAsk.force", false);
                profile.SetPreference("browser.download.manager.closeWhenDone", true);
                profile.SetPreference("browser.download.manager.showAlertOnComplete", true);
                profile.SetPreference("browser.download.manager.useWindow", false);
                profile.SetPreference("browser.download.panel.shown", false);
                Browser = new FirefoxDriver(profile);
                return Browser;
            }
            return null;
        }       
           
    }
}
