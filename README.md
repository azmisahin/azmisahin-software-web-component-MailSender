# Mail
Mail Sender PlugIn

Namespace: PlugIn.Mail



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
            
