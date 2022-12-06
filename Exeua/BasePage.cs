using OpenQA.Selenium;
using System;

namespace Exeua
{
    public class BasePage
    {
        protected IWebDriver driver;

        public BasePage(IWebDriver webDriver)
        {
            driver = webDriver;
        }
    }
}