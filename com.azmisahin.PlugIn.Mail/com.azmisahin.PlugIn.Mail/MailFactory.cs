using System;
using System.Net.Mail;
namespace com.azmisahin.PlugIn.Mail
{
    /// <summary>
    /// Smtp Mail Send
    /// </summary>
    public class MailFactory:IMailFactory
    {
        #region Filed
        private string _host { get; set; }
        private int _port { get; set; }
        private string _userName { get; set; }
        private string _password { get; set; }
        private bool _enableSsl { get; set; }
        private string _adress { get; set; }
        private string _subject { get; set; }
        private string _content { get; set; }
        private string _signature { get; set; }
        #endregion

        #region Property

        /// <summary>
        /// Set Host or Ip Adress
        /// </summary>
        /// <param name="host"></param>
        /// <returns></returns>
        public override IMailFactory setHost(string host)
        {
            this._host = host;
            return this;
        }

        /// <summary>
        /// Set Host Port Adress
        /// </summary>
        /// <param name="port"></param>
        /// <returns></returns>
        public override IMailFactory setPort(int port)
        {
            this._port = port;
            return this;
        }

        /// <summary>
        /// Set Server User Name
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        public override IMailFactory setUserName(string userName)
        {
            this._userName = userName;
            return this;
        }

        /// <summary>
        /// Set Server User Password
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public override IMailFactory setPassword(string password)
        {
            this._password = password;
            return this;
        }

        /// <summary>
        /// Set Server Credential
        /// </summary>
        /// <param name="isEnable"></param>
        /// <returns></returns>
        public override IMailFactory EnableSsl(bool isEnable)
        {
            this._enableSsl = isEnable;
            return this;
        }

        /// <summary>
        /// Set Receiver Mail Address
        /// </summary>
        /// <param name="adress"></param>
        /// <returns></returns>
        public override IMailFactory setMail(string adress)
        {
            this._adress = adress;
            return this;
        }

        /// <summary>
        /// Set Mail Subject
        /// </summary>
        /// <param name="subject"></param>
        /// <returns></returns>
        public override IMailFactory setSubject(string subject)
        {
            this._subject = subject;
            return this;
        }

        /// <summary>
        /// Set Mail Content
        /// </summary>
        /// <param name="content"></param>
        /// <returns></returns>
        public override IMailFactory setContent(string content)
        {
            this._content = content;
            return this;
        }

        /// <summary>
        /// Set Mail Signature
        /// </summary>
        /// <param name="signature"></param>
        /// <returns></returns>
        public override IMailFactory setSignature(string signature)
        {
            this._signature = signature;
            return this;
        }

        /// <summary>
        /// Send Mail Message
        /// </summary>
        /// <returns></returns>
        public override string Send()
        {
            string result = string.Empty;
            try
            {
                SmtpClient smtpClient = new SmtpClient();
                smtpClient.Host = this._host;
                smtpClient.Port = this._port;
                smtpClient.Credentials = new System.Net.NetworkCredential(this._userName, this._password);
                smtpClient.EnableSsl = this._enableSsl;

                MailMessage mailMessage = new MailMessage();
                mailMessage.IsBodyHtml = true;
                mailMessage.Priority = MailPriority.High;
                mailMessage.From = new MailAddress(this._userName);
                mailMessage.To.Add(this._adress);
                mailMessage.Subject = this._subject;
                mailMessage.Body = this._content + this._signature;
                smtpClient.Send(mailMessage);

                result = "Mail Send";
            }
            catch (Exception ex)
            {
                result = string.Format("Mail Don't Send : {0}", ex.Message.ToString());
            }
            return result;
        } 
        #endregion
    }
}
