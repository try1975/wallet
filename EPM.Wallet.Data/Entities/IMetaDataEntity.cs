﻿using System;

namespace EPM.Wallet.Data.Entities
{
    public interface IMetaDataEntity
    {
        DateTime CreatedAt { get; set; }
        DateTime UpdatedAt { get; set; }

        string CreatedBy { get; set; }
        string UpdatedBy { get; set; }
    }
}