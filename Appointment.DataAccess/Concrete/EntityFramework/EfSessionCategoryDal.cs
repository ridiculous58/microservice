using Appointment.DataAccess.Abstract;
using Appointment.Entities.Concrete;
using Core.DataAccess.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Appointment.DataAccess.Concrete.EntityFramework
{
    public class EfSessionCategoryDal:EfEntityRepositoryBase<SessionCategory,AppoinmentDbContext>,ISessionCategoryDal
    {
    }
}
