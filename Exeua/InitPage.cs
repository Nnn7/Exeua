using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exeua
{
    public class InitPage : BasePage
    {
        public InitPage(IWebDriver driver) : base(driver)
        {

        }

        private IWebElement LoginButton => driver.FindElement(By.XPath("//a[@href='/login/']"));

        public void ClickLoginButton() => LoginButton.Click();



    }
}
