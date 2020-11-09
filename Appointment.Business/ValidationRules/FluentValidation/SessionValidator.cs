using Appointment.Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Appointment.Business.ValidationRules.FluentValidation
{
    public class SessionValidator:AbstractValidator<Session>
    {
        public SessionValidator()
        {
            #region ValidationRulues
            #region ReceiptId
            RuleFor(s => s.ReceiptId).NotEmpty().WithMessage("ReceiptId cannot be Empty");
            RuleFor(s => s.ReceiptId).GreaterThanOrEqualTo(1);
            #endregion
            #region SessionCategoryId
            RuleFor(s => s.SessionCategoryId).NotEmpty().WithMessage("SessionCategoryId cannot be Empty");
            RuleFor(s => s.SessionCategoryId).GreaterThanOrEqualTo(1);
            #endregion
            #endregion
        }
    }
}
