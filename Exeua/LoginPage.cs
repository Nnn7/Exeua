using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exeua
{
    public class LoginPage : BasePage
    {
        public LoginPage(IWebDriver driver) : base(driver)
        {

        }

        private IWebElement textFieldEmail => driver.FindElement(By.XPath("//input[@name='login']"));
        private IWebElement textFieldPassword => driver.FindElement(By.XPath("//input[@name='password']"));
        private IWebElement LoginButton => driver.FindElement(By.XPath("//input[@value='Войти']"));
        private IWebElement errorMessage => driver.FindElement(By.TagName("em"));

        public void SendEmailToTextFieldEmail(string text) => textFieldEmail.SendKeys(text);
        public void SendPasswordToTextFieldPassword(string text) => textFieldPassword.SendKeys(text);
        public void ClickLoginButton() => LoginButton.Click();
        public string GetErrorMessage() => errorMessage.Text;



    }
}
