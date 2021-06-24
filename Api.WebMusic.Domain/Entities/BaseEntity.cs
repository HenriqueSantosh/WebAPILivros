using System;
using System.Collections.Generic;
using System.Text;

namespace Api.WebMusic.Domain.Entities
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }

        private DateTime _createAt;
        public DateTime  CreateAt
        {
            get { return _createAt; }
            set { _createAt = value; }
        }

        public DateTime? UpdateAt { get; set; }
    }
}
