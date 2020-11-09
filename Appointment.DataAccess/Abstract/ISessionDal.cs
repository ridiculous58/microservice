using Appointment.Entities.Concrete;
using Core.DataAccess;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Appointment.DataAccess.Abstract
{
    public interface ISessionDal:IEntityRepository<Session>
    {
    }
}
