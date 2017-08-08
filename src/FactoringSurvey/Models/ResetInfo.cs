using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FactoringSurvey.Models
{
    public class ResetInfo
    {
		public string Password { get; set; }
		public string UserError { get; set; }

		public string HiddenClass { get { return HasError ? "" : "hidden-item"; } }

		public int RepoCount { get; set; }

		public bool IsValidPassword()
		{
			return Password == "gosia.2017";
		}

		public bool HasError { get { return !string.IsNullOrEmpty(UserError); } }
	}
}
