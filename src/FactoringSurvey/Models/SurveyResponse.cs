using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FactoringSurvey.Models
{
	public enum Gender
	{
		Female = 0, Male = 1, Unspecified = 2
	}
	public enum Age
	{
		Twenties = 20,
		Thirties = 30,
		Fourties = 40,
		Fifties = 50,
		SixtyPlus = 60,
		Unspecified = 0
	}

	public class SurveyResponse
    {
		[Required(ErrorMessage ="Please enter your favorite pet animal")]
		public string FavoritePet { get; set; }

		[Required(ErrorMessage ="Please enter your name")]
		public string Name { get; set; }

		[Required(ErrorMessage ="Please enter your country")]
		public string Country { get; set; }

		[Required(ErrorMessage ="Please enter your age")]
		public Age Age { get; set; }

		public Gender? Gender { get; set; }

		[MaxLength(240, ErrorMessage ="Enter max 240 characters")]
		public string Comment { get; set; }
	}
}
