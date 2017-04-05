using System;
using System.Collections.Generic;
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
        private readonly IMessageApi _messageApi;
        private readonly ExchangeServiceMailSender _mailSender;

        public MessagesByClientController(IMessageApi messageApi, ExchangeServiceMailSender mailSender)
        {
            _messageApi = messageApi;
            _mailSender = mailSender;
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
            return Ok(_messageApi.CountUnreadMessagesByClient(clientId));
        }

        /// <summary>
        ///     Client message list
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="from"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        [HttpGet]
        [ResponseType(typeof(int))]
        [Route("", Name = nameof(GetMessagesByClient) + Ro.Route)]
        public IEnumerable<MessageDto> GetMessagesByClient(string clientId, int from = 0, int count = 0)
        {
            return _messageApi.GetMessagesByClient(clientId, from, count);
        }

        /// <summary>
        ///     Client outgoing message list
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="from"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        [HttpGet]
        [Route(WalletConstants.MessagesByClientRoutes.Outgoing, Name = nameof(GetMessagesByClientOutgoing) + Ro.Route)]
        public IEnumerable<MessageDto> GetMessagesByClientOutgoing(string clientId, int from = 0, int count = 0)
        {
            return _messageApi.GetOutgoingMessagesByClient(clientId, from, count);
        }

        /// <summary>
        ///     Client incomming message list from date
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="fromDate"></param>
        /// <param name="from"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        [HttpGet]
        [Route(WalletConstants.MessagesByClientRoutes.Incomming, Name = nameof(GetMessagesByClientIncoming) + Ro.Route)]
        public IEnumerable<MessageDto> GetMessagesByClientIncoming(string clientId, DateTime fromDate, int from=0, int count=0)
        {
            return _messageApi.GetIncomingMessagesByClient(clientId, fromDate, from, count);
        }


        [HttpGet]
        [ResponseType(typeof(MessageDto))]
        [Route("{id:guid}", Name = nameof(GetMessageByClient) + Ro.Route)]
        public IHttpActionResult GetMessageByClient(string clientId, Guid id)
        {
            var messageDto = _messageApi.GetMessageByClient(clientId, id);
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
            messageDto = _messageApi.PostMessageByClient(clientId, messageDto);
            // send email
            var subject = $"[{clientId}] {messageDto.Subject}";
            var body = messageDto.Body;
            _mailSender.SendMail(subject, body, AppGlobal.EmailMessage);
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
            var messageDto = _messageApi.MakeMessageReaded(clientId, id);
            return Ok(messageDto);
        }
    }
}