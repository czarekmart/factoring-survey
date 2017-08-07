using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FactoringSurvey.Models
{
    public interface ISurveyRepository
    {
		IEnumerable<SurveyResponse> GetResponses();
		void AddResponse(SurveyResponse response) ;
		void SetHostingEnvironment(IHostingEnvironment hostingEnvironment);
    }
}
