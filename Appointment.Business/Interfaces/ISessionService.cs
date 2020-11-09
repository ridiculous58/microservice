using Appointment.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Appointment.Business.Interfaces
{
    public interface ISessionService
    {
        List<Session> GetAll();
        Session Add(Session session); 
        
    }
}
