﻿using System;

namespace EPM.Wallet.Internal.Model
{
    public class MessageDto : IDto<Guid>
    {
        private DateTime? _createdAt;

        public Guid Id { get; set; }
        public string ClientId { get; set; }

        public DateTime Date
        {
            get
            {
                return _createdAt ?? DateTime.UtcNow;
            }
            set { _createdAt = value; }
        }

        public string Subject { get; set; }
        public string Body { get; set; }

        public DateTime? ReadDate { get; set; }
        public DateTime? DeletionDate { get; set; }

        public bool IsOutgoing { get; set; }
    }
}