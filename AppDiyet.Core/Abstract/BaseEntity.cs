using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppDiyet.Core.Enums;

namespace AppDiyet.Core.Abstract
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public Status Status { get; set; } = Status.Created;
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public DateTime? UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }

    }
}
