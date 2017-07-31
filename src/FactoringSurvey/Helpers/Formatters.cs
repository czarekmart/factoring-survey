using FactoringSurvey.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FactoringSurvey.Helpers
{
    public static class Formatters
    {
		public static string GradeCaption(int gradeIndex)
		{
			switch(gradeIndex)
			{
				case 0:
				case 4:
				case 5:
				case 6:
				case 7:
				case 8:
				case 9:
				case 10:
				case 11:
				case 12:
					return string.Format("{0}<sup>th</sup>", gradeIndex);
				case 1:
					return "1<sup>st</sup>";
				case 2:
					return "2<sup>nd</sup>";
				case 3:
					return "3<sup>rd</sup>";
				case 13:
					return "College";
				default:
					return gradeIndex.ToString();

			}
		}

		public static string GradeCheckboxes(string aspFor)
		{
			var htmlOutput = string.Empty;
			try
			{
				for(var grade = 6; grade < SurveyResponse.GradeCount; grade++)
				{
					htmlOutput += string.Format(@"<div class=""checkbox-inline""><label><input type=""checkbox"" asp-for=""{0}[{1}]"">", aspFor, grade);
					htmlOutput += GradeCaption(grade);
					htmlOutput += "</label></div>" + System.Environment.NewLine;
				}
			}
			catch(Exception ex)
			{
				System.Diagnostics.Debug.WriteLine(ex.Message);
			}
			return htmlOutput;
		}
	}
}
