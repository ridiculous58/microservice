using Appointment.Entities.Concrete;
using Core.DataAccess;
using System;
using System.Collections.Generic;
using System.Text;

namespace Appointment.DataAccess.Abstract
{
    public interface ITherapistDal:IEntityRepository<Therapist>
    {
    }
}
