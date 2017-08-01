using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FactoringSurvey.Models
{
	public class EnumOption
	{
		public short Value { get; set; }
		public string Description { get; set; }

		public EnumOption(short value, string description)
		{
			Value = value;
			Description = description;
		}
	}

    public static class EnumOptions
    {
		public const short Unspecified = 0;

		public const short GenderFemale = 1;
		public const short GenderMale = 2;

		public const short AgeTwenties = 20;
		public const short AgeThirties = 30;
		public const short AgeFourties = 40;
		public const short AgeFifties = 50;
		public const short AgeSixtyPlus = 60;

		public const int EvalEffective		= 4;
		public const int EvalMixed			= 3;
		public const int EvalDontKnow		= 2;
		public const int EvalNotEffective	= 1;

		public static IEnumerable<EnumOption> Genders
		{
			get
			{
				return new[]
				{
					new EnumOption(Unspecified, "Unspecified"),
					new EnumOption(GenderFemale, "Female"),
					new EnumOption(GenderMale, "Male")
				};
			}
		}
		public static IEnumerable<EnumOption> Ages
		{
			get
			{
				return new[]
				{
					new EnumOption(Unspecified, "Unspecified"),
					new EnumOption(AgeTwenties, "20-29"),
					new EnumOption(AgeThirties, "30-39"),
					new EnumOption(AgeFourties, "40-49"),
					new EnumOption(AgeFifties, "50-59"),
					new EnumOption(AgeSixtyPlus, "60+"),
				};
			}
		}
		public static string GetDescription(this IEnumerable<EnumOption> options, short value)
		{
			var opt = options.FirstOrDefault(o=>o.Value == value);
			return opt == null ? string.Empty : opt.Description;
		}
	}
}
