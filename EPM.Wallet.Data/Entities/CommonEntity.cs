using System;

namespace EPM.Wallet.Data.Entities
{
    public class CommonEntity: IMetaDataEntity
    {
        private DateTime? _createdAt;
        private DateTime? _updatedAt;

        public DateTime CreatedAt
        {
            get
            {
                return _createdAt ?? DateTime.UtcNow;
            }
            set { _createdAt = value; }
        }

        public DateTime UpdatedAt
        {
            get { return _updatedAt ?? DateTime.UtcNow; }
            set { _updatedAt = value; }
        }

        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
    }
}
