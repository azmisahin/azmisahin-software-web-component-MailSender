using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Configuration;

namespace com.azmisahin.PlugIn.Mail.Tests
{
    [TestClass]
    public class MailManagerTest
    {
        [TestMethod]
        public void ManagerTest()
        {
            var Host = getAppKey("PlugIn.Mail.Host");
            var Port = Convert.ToInt32(getAppKey("PlugIn.Mail.Port"));
            var UserName =getAppKey("PlugIn.Mail.UserName");
            var Password = getAppKey("PlugIn.Mail.Password");
            var EnableSsl = Convert.ToBoolean(getAppKey("PlugIn.Mail.EnableSsl"));
            var Mail = getAppKey("PlugIn.Mail.Mail");
            var Subject=getAppKey("PlugIn.Mail.Subject");
            var Content=getAppKey("PlugIn.Mail.Content");
            var Signature = string.Format("<br><br><br>{0}",getAppKey("PlugIn.Mail.Signature"));

            var result = 
                MailManager
                .Initalize
                .setHost(Host)
                .setPort(Port)
                .setUserName(UserName)
                .setPassword(Password)
                .EnableSsl(EnableSsl)
                .setMail(Mail)
                .setSubject(Subject)
                .setContent(Content)
                .setSignature(Signature)
                .Send();
            Console.WriteLine(result);
        }

        #region Configuration
        /// <summary>
        /// Application Key
        /// </summary>
        /// <param name="key">appSettings Key</param>
        /// <returns>value</returns>
        private string getAppKey(string key)
        {
            var value = ConfigurationManager.AppSettings[key].ToString();
            return value;
        }
        #endregion
    }
}
