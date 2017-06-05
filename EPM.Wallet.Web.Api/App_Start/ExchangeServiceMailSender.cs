using System;
using log4net;
using Microsoft.Exchange.WebServices.Data;

namespace WalletWebApi
{
    public class ExchangeServiceMailSender
    {
        private static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private readonly ExchangeService _service;

        public ExchangeServiceMailSender()
        {
            // Identify the Exchange service.
            _service = new ExchangeService(ExchangeVersion.Exchange2013)
            {
                Url = new Uri(AppGlobal.ExchangeServiceUrl),
                Credentials = new WebCredentials(AppGlobal.ExchangeServiceUserName, AppGlobal.ExchangeServicePassword)
            };

            //var ews = new ExchangeServiceBinding();
        }

        internal void SendMail(string subject, string body, string recipient)
        {
            //try
            //{
                var message = new EmailMessage(_service)
                {
                    Subject = subject,
                    Body = body
                };
                message.ToRecipients.Add(recipient);
                //message.SendAndSaveCopy();
                //System.Threading.Tasks.Task.Run(() =>  message.SendAndSaveCopy());

                System.Threading.Tasks.Task.Run(() =>
                {
                    try
                    {
                        message.SendAndSaveCopy();
                    }
                    catch (Exception ex)
                    {
                        Log.Error(ex.Message);
                    }
                });
            //}
            //catch (Exception ex)
            //{
            //    Debug.WriteLine($"{ex}");
            //    Log.Error(ex);
            //}
        }
    }
}