using System;
using ConsoleApp1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class EmailValidatorTests
    {
        [TestMethod]
        public void IsValidEmail_ReturnTrue_ForValidEmail()
        {
            var validator = new EmailValidator();
            string input = "test@example.com";

            bool result = validator.IsValidEmail(input);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void EmptyEmail_ReturnsFalse()
        {
            var validator = new EmailValidator();
            string input = "";

            bool result = validator.IsValidEmail(input);

            Assert.IsFalse(result);
        }
        
        [TestMethod]
        public void EmailWithoutAtSymbol_ReturnsFalse()
        {
            var validator = new EmailValidator();
            string input = "testexample.com";

            bool result = validator.IsValidEmail(input);

            Assert.IsFalse(result);
        }
        
        [TestMethod]
        public void EmailWithMultipleAtSymbols_ReturnsFalse()
        {
            var validator = new EmailValidator();
            string input = "test@@example.com";

            bool result = validator.IsValidEmail(input);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void EmailWithoutDomain_ReturnsFalse()
        {
            var validator = new EmailValidator();
            string input = "test@";

            bool result = validator.IsValidEmail(input);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void EmailWithoutLocalPart_ReturnsFalse()
        {
            var validator = new EmailValidator();
            string input = "@example.com";

            bool result = validator.IsValidEmail(input);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void EmailWithoutTLD_ReturnsFalse()
        {
            var validator = new EmailValidator();
            string input = "test@example";

            bool result = validator.IsValidEmail(input);

            Assert.IsFalse(result);
        }
    }
}
