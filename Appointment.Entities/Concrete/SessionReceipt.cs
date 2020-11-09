using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Appointment.Entities.Concrete
{
    public class SessionReceipt:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public  string Explanation { get; set; }
        public double Price { get; set; }

    }
}
