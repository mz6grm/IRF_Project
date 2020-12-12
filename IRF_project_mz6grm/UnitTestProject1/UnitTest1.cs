using System;
using IRF_project_mz6grm;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace UnitTestProject1
{
	[TestClass]
	public class UnitTest1
	{
        [
            Test,
            TestCase("abcd1234", false),
            TestCase("irf@uni-corvinus", false),
            TestCase("irf.uni-corvinus.hu", false),
            TestCase("irf@uni-corvinus.hu", true)
        ]
        public void TestValidateEmail(string email, bool expectedresult)
        {
            var register = new Register();

            var actualResult = register.ValidateEmail(email); 

            NUnit.Framework.Assert.AreEqual(expectedresult, actualResult); //kapott eredménye egyenlő elvártal
        }

        [
            Test,
            TestCase("abcd1234", true),
            TestCase("abcd", false)           
        ]
        public void TestValidateUsername(string username, bool expectedresult)
        {
            var register = new Register();

            var actualResult = register.ValidateUsername(username);

            NUnit.Framework.Assert.AreEqual(expectedresult, actualResult);
        }

        [
            Test,
            TestCase("abcd4444", false),
            TestCase("Abcdefghi", false),
            TestCase("Abcd1", false),
            TestCase("Abcd12345", true)
        ]
        public void TestValidatePassword(string password, bool expectedresult)
        {
            var register = new Register();

            var actualResult = register.ValidatePassword(password);

            NUnit.Framework.Assert.AreEqual(expectedresult, actualResult);
        }

        [
            Test,
            TestCase("123123", false),
            TestCase("123123123123", false),
            TestCase("123123123", true)
        ]
        public void TestValidatePhoneNumber(string phonenumber, bool expectedresult)
        {
            var register = new Register();

            var actualResult = register.ValidatePhoneNumber(phonenumber);

            NUnit.Framework.Assert.AreEqual(expectedresult, actualResult);
        }
    }
}
