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
		void Configure(Microsoft.AspNetCore.Hosting.IHostingEnvironment hostingEnvironment, Microsoft.Extensions.Configuration.IConfiguration configuration);
		string GetRepoPath();
    }
}
