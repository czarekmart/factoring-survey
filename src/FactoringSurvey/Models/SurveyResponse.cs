using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FactoringSurvey.Models
{
	public class SurveyResponse
    {
		[Required(ErrorMessage ="Please enter your name")]
		[MaxLength(80)]
		public string Name { get; set; }

		[Required(ErrorMessage ="Please enter your country")]
		[MaxLength(50)]
		public string Country { get; set; }

		[Required(ErrorMessage ="Please enter your email")]
		[MaxLength(50)]
		public string Email { get; set; }

		public short Gender { get; set; }   // one of GenderOptions

		public short Age { get; set; }		// one of AgeOptions

		[MaxLength(50)]
		public string SchoolName { get; set; }

		[MaxLength(50)]
		public string MathQualification { get; set; } 

		public int YearsOfTeachingMath { get; set; } 

		public bool TeachingGrade6					{ get; set; }
		public bool TeachingGrade7					{ get; set; }
		public bool TeachingGrade8					{ get; set; }
		public bool TeachingGrade9					{ get; set; }
		public bool TeachingGrade10					{ get; set; }
		public bool TeachingGrade11					{ get; set; }
		public bool TeachingGrade12					{ get; set; }
		public bool TeachingGradeCollege			{ get; set; }

		public bool TeachingCourseBasic				{ get; set; }
		public bool TeachingCoursePreAlgebra		{ get; set; }
		public bool TeachingCourseAlgebra1			{ get; set; }
		public bool TeachingCourseIntegrated		{ get; set; }
		public bool TeachingCourseAlgebra2			{ get; set; }
		public bool TeachingCoursePreCalculus		{ get; set; }
		public bool TeachingCourseCalculus			{ get; set; }
		public bool TeachingCourseProbability		{ get; set; }

		[MaxLength(50)]
		public string CourseOther			{ get; set; }

		[MaxLength(240)]
		public string Comment { get; set; }




	}
}
