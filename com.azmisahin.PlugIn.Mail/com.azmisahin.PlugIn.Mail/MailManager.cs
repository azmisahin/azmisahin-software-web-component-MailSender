using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.azmisahin.PlugIn.Mail
{
    /// <summary>
    /// Mail Manager
    /// </summary>
    public class MailManager
    {
        /// <summary>
        /// Direct Access
        /// </summary>
        public static volatile MailFactory instance;

        /// <summary>
        /// Instance Based Siglation
        /// </summary>
        public static IMailFactory Initalize
        {
            get { if (instance == null) instance = new MailFactory(); return instance; }
        }
    }
}
