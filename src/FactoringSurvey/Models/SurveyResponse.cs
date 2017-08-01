using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace FactoringSurvey.Models
{
	public class SurveyResponse
    {
		public const int MaxCommentLength = 240;
		public const int GradeCount = 13 + 1;


		// Part 1

		[Required(ErrorMessage ="Please enter your name")]
		[MaxLength(80)]
		public string Name									{ get; set; }

		[Required(ErrorMessage ="Please enter your country")]
		[MaxLength(50)]
		public string Country								{ get; set; }

		[Required(ErrorMessage ="Please enter your email")]
		[MaxLength(50)]
		public string Email { get; set; }

		public short Gender									{ get; set; }   // one of GenderOptions

		public short Age									{ get; set; }		// one of AgeOptions

		[MaxLength(50)]
		public string SchoolName							{ get; set; }

		[MaxLength(50)]
		public string MathQualification						{ get; set; } 

		public int YearsOfTeachingMath						{ get; set; } 

		public bool[] TaughtGrade							{ get; set ; } = new bool[GradeCount];

		public bool TeachingCourseBasic						{ get; set; }
		public bool TeachingCoursePreAlgebra				{ get; set; }
		public bool TeachingCourseAlgebra1					{ get; set; }
		public bool TeachingCourseIntegrated				{ get; set; }
		public bool TeachingCourseAlgebra2					{ get; set; }
		public bool TeachingCoursePreCalculus				{ get; set; }
		public bool TeachingCourseCalculus					{ get; set; }
		public bool TeachingCourseProbability				{ get; set; }

		[MaxLength(50)]
		public string CourseOther							{ get; set; }

		// Part 2

		// Question 11

		public int TaughtFactoringInAlgebra1Years			{ get; set; }
		public bool[] TaughtFactoringInAlgebra1Grades		{ get; set ; } = new bool[GradeCount];

		public int TaughtFactoringInAlgebra2Years			{ get; set; }
		public bool[] TaughtFactoringInAlgebra2Grades		{ get; set ; } = new bool[GradeCount];

		public int TaughtFactoringInPrecalculusYears		{ get; set; }
		public bool[] TaughtFactoringInPrecalculusGrades	{ get; set ; } = new bool[GradeCount];

		public int TaughtFactoringInCalculusYears			{ get; set; }
		public bool[] TaughtFactoringInCalculusGrades		{ get; set ; } = new bool[GradeCount];

		[MaxLength(50)]
		public string TaughtFactoringInOtherSpecified		{ get; set; }
		public int TaughtFactoringInOtherYears				{ get; set; }
		public bool[] TaughtFactoringInOtherGrades			{ get; set ; } = new bool[GradeCount];


		// Question 12

		public bool[] TeachingNowInAlgebra1Grades			{ get; set ; } = new bool[GradeCount];
		public bool[] TeachingNowInAlgebra2Grades			{ get; set ; } = new bool[GradeCount];
		public bool[] TeachingNowInPrecalculusGrades		{ get; set ; } = new bool[GradeCount];
		public bool[] TeachingNowInCalculusGrades			{ get; set ; } = new bool[GradeCount];
		public bool[] TeachingNowInOtherGrades				{ get; set ; } = new bool[GradeCount];
		[MaxLength(50)]
		public string TeachingNowInOtherSpecified			{ get; set ; }

		// Question 13
		public bool FactoringMethodDiff2Squares				{ get; set; }
		public bool FactoringMethodQuadraticFormula			{ get; set; }
		public bool FactoringMethodGuessAndCheck			{ get; set; }
		public bool FactoringMethodCompletingSquare			{ get; set; }
		public bool FactoringMethodSquareOfBinomial			{ get; set; }
		public bool FactoringMethodGrouping					{ get; set; }
		public bool FactoringMethodCommonFactor				{ get; set; }
		public bool FactoringMethodOther					{ get; set; }
		[MaxLength(50)]
		public string FactoringMethodOtherSpecified			{ get; set; }

		// Question 14
		[MaxLength(MaxCommentLength)]
		public string MostChallengingPart					{ get; set; }

		// Question 15
		[MaxLength(MaxCommentLength)]
		public string WhatToAddToCurriculum					{ get; set; }

		// Question 16
		[MaxLength(MaxCommentLength)]
		public string WhatToSubractFromCurriculum			{ get; set; }

		// Question 17
		[MaxLength(MaxCommentLength)]
		public string WhatIsSuccessfulTeaching				{ get; set; }

		// Question 18
		public int TeachingSuccess							{ get; set; }


		// Part 3

		// Question 19
		public int ConfidentWithTechnology					{ get; set; }

		// Question 20
		public int CanTechnologyBeMoreEffective				{ get; set; }
		[MaxLength(MaxCommentLength)]
		public string CanTechnologyBeEffectiveComment		{ get; set; }

		// Question 21
		public int AccessToGraphingCalculator				{ get; set; }
		public int AccessToBlackboard						{ get; set; }
		public int AccessToIpad								{ get; set; }
		public int AccessToGames							{ get; set; }
		public int AccessToSmartBoards						{ get; set; }
		public int AccessToPresentationSoftware				{ get; set; }
		public int AccessToCloudSharing						{ get; set; }
		public int AccessToComputerizedTesting				{ get; set; }
		public int AccessToSocialMedia						{ get; set; }
		public int AccessToMultimediaProjector				{ get; set; }
		public int AccessToClassroomResponseSystem			{ get; set; }
		public int AccessToCAI								{ get; set; }
		public int AccessToOnlineProjects					{ get; set; }
		public int AccessToInformationVisualization			{ get; set; }
		public int AccessToOther							{ get; set; }
		[MaxLength(120)]
		public string AccessToOtherSpecified				{ get; set; }

		// Question 22
		public int IncorporateGraphingCalculator			{ get; set; }
		public int IncorporateBlackboard					{ get; set; }
		public int IncorporateIpad							{ get; set; }
		public int IncorporateGames							{ get; set; }
		public int IncorporateSmartBoards					{ get; set; }
		public int IncorporatePresentationSoftware			{ get; set; }
		public int IncorporateCloudSharing					{ get; set; }
		public int IncorporateComputerizedTesting			{ get; set; }
		public int IncorporateSocialMedia					{ get; set; }
		public int IncorporateMultimediaProjector			{ get; set; }
		public int IncorporateClassroomResponseSystem		{ get; set; }
		public int IncorporateCAI							{ get; set; }
		public int IncorporateOnlineProjects				{ get; set; }
		public int IncorporateInformationVisualization		{ get; set; }
		public int IncorporateOther							{ get; set; }
		[MaxLength(120)]
		public string IncorporateOtherSpecified				{ get; set; }

		// Question 23
		public int UseToDifferenceOfSquares					{ get; set; }
		public int UseToQuadraticFormula					{ get; set; }
		public int UseToGuessAndCheck						{ get; set; }
		public int UseToCompleteSquare						{ get; set; }
		public int UseToSquareOfBinomial					{ get; set; }
		public int UseToGrouping							{ get; set; }
		public int UseToCommonFactor						{ get; set; }
		public int UseToOther								{ get; set; }
		[MaxLength(120)]
		public string UseToOtherSpecified					{ get; set; }

		// Question 24
		public int GoalToComplyToPrincipal					{ get; set; }
		public int GoalToPresentProblems					{ get; set; }
		public int GoalToComputations						{ get; set; }
		public int GoalToGraph								{ get; set; }
		public int GoalToCheckAnswers						{ get; set; }
		public int GoalToStudentKnowledge					{ get; set; }
		public int GoalToCommunicate						{ get; set; }
		public int GoalToEngageStudents						{ get; set; }
		public int GoalToIndividualizeLearning				{ get; set; }
		public int GoalToDifferentReprentations				{ get; set; }
		public int GoalToTeachTechnology					{ get; set; }
		public int GoalToOther								{ get; set; }
		[MaxLength(120)]
		public string GoalToOtherSpecified					{ get; set; }
	}
}
