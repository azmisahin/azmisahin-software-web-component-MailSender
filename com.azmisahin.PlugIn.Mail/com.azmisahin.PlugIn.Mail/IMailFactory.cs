namespace com.azmisahin.PlugIn.Mail
{
    /// <summary>
    /// Mail Factory
    /// </summary>
    public abstract class IMailFactory
    {
        /// <summary>
        /// Host Name Or Ip Adress
        /// </summary>
        /// <param name="server"></param>
        /// <returns></returns>
        public abstract IMailFactory setHost(string server);

        /// <summary>
        /// Host Port Adres
        /// </summary>
        /// <param name="port"></param>
        /// <returns></returns>
        public abstract IMailFactory setPort(int port);

        /// <summary>
        /// Host Authenticated User Name
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        public abstract IMailFactory setUserName(string userName);

        /// <summary>
        /// Host Authenticated User Password
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public abstract IMailFactory setPassword(string password);

        /// <summary>
        /// Host SSL Requared
        /// </summary>
        /// <param name="isEnable"></param>
        /// <returns></returns>
        public abstract IMailFactory EnableSsl(bool isEnable);

        /// <summary>
        /// Sending Mal Adres
        /// </summary>
        /// <param name="adress"></param>
        /// <returns></returns>
        public abstract IMailFactory setMail(string adress);

        /// <summary>
        /// Sendng Mail Adress
        /// </summary>
        /// <param name="subject"></param>
        /// <returns></returns>
        public abstract IMailFactory setSubject(string subject);

        /// <summary>
        /// Mail Conetnt
        /// </summary>
        /// <param name="content"></param>
        /// <returns></returns>
        public abstract IMailFactory setContent(string content);

        /// <summary>
        /// Mail Signature
        /// </summary>
        /// <param name="signature"></param>
        /// <returns></returns>
        public abstract IMailFactory setSignature(string signature);

        /// <summary>
        /// Send Progress
        /// </summary>
        /// <returns></returns>
        public abstract string Send();
    }
}
