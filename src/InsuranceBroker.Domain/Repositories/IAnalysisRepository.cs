using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InsuranceBroker.Domain.Models;

namespace InsuranceBroker.Domain.Repositories
{
    public interface IAnalysisRepository
    {
        List<Analysis> GetAllByUserId(Guid userId);

        Analysis Create(Analysis analysis);

        Analysis Update(Analysis analysis);

        bool Delete(Guid analysisId);
    }
}
