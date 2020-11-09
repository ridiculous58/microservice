using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Appointment.Entities.Concrete
{
    public class Session:IEntity
    {
        public int Id { get; set; }
        public int SessionCategoryId { get; set; }
        public DateTime SessionDate { get; set; }
        public int ReceiptId { get; set; }

    }
}
