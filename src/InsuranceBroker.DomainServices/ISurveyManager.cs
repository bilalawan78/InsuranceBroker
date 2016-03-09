using System;
using System.Collections.Generic;
using InsuranceBroker.DomainServices.Models;

namespace InsuranceBroker.DomainServices
{
    public interface ISurveyManager
    {
        List<Survey> GetSurveysByUserId(Guid userId);
    }
}