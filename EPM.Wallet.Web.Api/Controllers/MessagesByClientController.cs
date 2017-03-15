using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Web.Http;
using System.Web.Http.Description;
using EPM.Wallet.Common;
using WalletWebApi.Maintenance;
using WalletWebApi.Model;

namespace WalletWebApi.Controllers
{
    [RoutePrefix(WalletConstants.ClientAppApi.MessagesByClient)]
    [Authorize]
    public class MessagesByClientController : ApiController
    {
        private readonly IMessageApi _api;

        public MessagesByClientController(IMessageApi api)
        {
            _api = api;
        }

        /// <summary>
        ///     Client uread message count
        /// </summary>
        /// <param name="clientId"></param>
        /// <returns></returns>
        [HttpGet]
        [Authorize]
        [Route(WalletConstants.MessagesByClientRoutes.UnreadCount, Name = nameof(GetMessagesByClientUnreadCount) + Ro.Route)]
        public IHttpActionResult GetMessagesByClientUnreadCount(string clientId)
        {
            return Ok(_api.CountUnreadMessagesByClient(clientId));
        }

        /// <summary>
        ///     Client message list
        /// </summary>
        /// <param name="clientId"></param>
        /// <returns></returns>
        [HttpGet]
        [ResponseType(typeof(int))]
        [Route("", Name = nameof(GetMessagesByClient) + Ro.Route)]
        public IEnumerable<MessageDto> GetMessagesByClient(string clientId)
        {
            return _api.GetMessagesByClient(clientId);
        }

        /// <summary>
        ///     Client outgoing message list
        /// </summary>
        /// <param name="clientId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route(WalletConstants.MessagesByClientRoutes.Outgoing, Name = nameof(GetMessagesByClientOutgoing) + Ro.Route)]
        public IEnumerable<MessageDto> GetMessagesByClientOutgoing(string clientId)
        {
            return _api.GetOutgoingMessagesByClient(clientId);
        }

        /// <summary>
        ///     Client incomming message list from date
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="fromDate"></param>
        /// <returns></returns>
        [HttpGet]
        [Route(WalletConstants.MessagesByClientRoutes.Incomming, Name = nameof(GetMessagesByClientIncoming) + Ro.Route)]
        public IEnumerable<MessageDto> GetMessagesByClientIncoming(string clientId, DateTime fromDate)
        {
            return _api.GetIncomingMessagesByClient(clientId, fromDate);
        }


        [HttpGet]
        [ResponseType(typeof(MessageDto))]
        [Route("{id:guid}", Name = nameof(GetMessageByClient) + Ro.Route)]
        public IHttpActionResult GetMessageByClient(string clientId, Guid id)
        {
            var messageDto = _api.GetMessageByClient(clientId, id);
            return Ok(messageDto);
        }

        /// <summary>
        ///     New message
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="messageDto"></param>
        /// <returns></returns>
        [HttpPost]
        [ResponseType(typeof(MessageDto))]
        [Route("", Name = nameof(PostMessageByClient) + Ro.Route)]
        public IHttpActionResult PostMessageByClient(string clientId, MessageDto messageDto)
        {
            if (messageDto == null || !ModelState.IsValid)
            {
                return BadRequest();
            }
            messageDto = _api.PostMessageByClient(clientId, messageDto);
            using (var message = new MailMessage())
            {
                message.To.Add(AppGlobal.EmailAboutMessage);
                message.Body = messageDto.Body;
                message.BodyEncoding = System.Text.Encoding.UTF8;
                message.Subject = messageDto.Subject;
                message.SubjectEncoding = System.Text.Encoding.UTF8;
                try
                {
                    var smtpClient = new SmtpClient();
                    smtpClient.Send(message);
                }
                catch (Exception) {/*ignored*/}
            }
            return Ok(messageDto);
        }

        /// <summary>
        ///     Make message readed
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPut]
        [ResponseType(typeof(MessageDto))]
        [Route("{id:guid}", Name = nameof(PutMakeMessageReaded) + Ro.Route)]
        public IHttpActionResult PutMakeMessageReaded(string clientId, Guid id)
        {
            var messageDto = _api.MakeMessageReaded(clientId, id);
            return Ok(messageDto);
        }
    }
}