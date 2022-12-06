using NUnit.Framework;
using Exeua;
using System.Threading;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    public class LoginTest : BaseTest
    {
        [Test]
        public void NegativeLogin()
        {
            InitPage init = new InitPage(driver);
            init.ClickLoginButton();
            Thread.Sleep(1000);
            LoginPage login = new LoginPage(driver);
            login.SendEmailToTextFieldEmail("Test@Email.net");
            login.SendPasswordToTextFieldPassword("TestPassword");
            Thread.Sleep(1000);
            login.ClickLoginButton();
            Thread.Sleep(1000);     
            string errorMessageText = login.GetErrorMessage();
            string expectedError = "Неправильное имя пользователя или пароль.";
            Assert.AreEqual(expectedError, errorMessageText, $"{expectedError} is not equal to {errorMessageText}");
        }
    }
}
