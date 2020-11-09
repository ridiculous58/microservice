using Appointment.Business.Interfaces;
using Appointment.Business.ValidationRules.FluentValidation;
using Appointment.DataAccess.Abstract;
using Appointment.Entities.Concrete;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Transaction;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation.FluentValidation;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Appointment.Business.Concretes
{
    public class SessionManager : ISessionService
    {
        private ISessionDal _sessionDal;
        public SessionManager(ISessionDal sessionDal)
        {
            _sessionDal = sessionDal;
        }

        [ValidationAspect(typeof(SessionValidator),Priority = 1)]
        [TransactionScopeAspect]
        [CacheRemoveAspect("ISessionService.Get")]
        public Session Add(Session session)
        {
            return _sessionDal.Add(session);
        }
        [CacheAspect(duration: 5)]
        public List<Session> GetAll()
        {
            return _sessionDal.GetList();
        }
    }
}
