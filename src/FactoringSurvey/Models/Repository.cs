using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FactoringSurvey.Models
{
    public class Repository
    {
		private static List<SurveyResponse> _responses;
		public static IEnumerable<SurveyResponse> Responses
		{
			get
			{
				return _responses ?? Enumerable.Empty<SurveyResponse>();
			}
		}

		public static void AddResponse(SurveyResponse response)
		{
			if(_responses == null)
				_responses = new List<SurveyResponse>();
			_responses.Add(response);
		}
    }
}
