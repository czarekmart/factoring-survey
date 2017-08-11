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

		public DateTime SurveyTime							{ get; set; }

		// Part 1-11

		[Required(ErrorMessage ="Please enter your name")]
		[MaxLength(80)]
		public string Name									{ get; set; }

		[Required(ErrorMessage ="Please enter your country")]
		[MaxLength(50)]
		public string Country								{ get; set; }

		[Required(ErrorMessage ="Please enter your email")]
		[MaxLength(50)]
		public string Email { get; set; }

		public short Gender									{ get; set; } = EnumOptions.GenderFemale;

		public short Age									{ get; set; } = EnumOptions.AgeTwenties;

		[MaxLength(50)]
		public string SchoolName							{ get; set; }

		[MaxLength(50)]
		public string MathQualification						{ get; set; }

		public bool TookMathForSecondary					{ get; set; }
		public bool TookMathForHighSchool					{ get; set; }
		public bool TookGeometryForTeachers					{ get; set; }
		public bool TookMathMethods							{ get; set; }
		public bool TookPrecalculus							{ get; set; }
		public bool TookCalculus1							{ get; set; }
		public bool TookCalculus2							{ get; set; }
		public bool TookCalculus3							{ get; set; }
		public bool TookMathHistory							{ get; set; }
		public bool TookAbstractAlgebra						{ get; set; }

		public int YearsOfTeachingMath						{ get; set; } 

		public bool TaughtGrade6							{ get; set ; }
		public bool TaughtGrade7							{ get; set ; }
		public bool TaughtGrade8							{ get; set ; }
		public bool TaughtGrade9							{ get; set ; }
		public bool TaughtGrade10							{ get; set ; }
		public bool TaughtGrade11							{ get; set ; }
		public bool TaughtGrade12							{ get; set ; }
		public bool TaughtCollege							{ get; set ; }

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

		// Question 12

		public bool NotTaughtTrinomials						{ get; set; }

		public int TaughtFactoringInAlgebra1Years			{ get; set; }
		public bool TaughtInAlgebra1Grade6					{ get; set ; }
		public bool TaughtInAlgebra1Grade7					{ get; set ; }
		public bool TaughtInAlgebra1Grade8					{ get; set ; }
		public bool TaughtInAlgebra1Grade9					{ get; set ; }
		public bool TaughtInAlgebra1Grade10					{ get; set ; }
		public bool TaughtInAlgebra1Grade11					{ get; set ; }
		public bool TaughtInAlgebra1Grade12					{ get; set ; }
		public bool TaughtInAlgebra1College					{ get; set ; }	

		public int TaughtFactoringInAlgebra2Years			{ get; set; }
		public bool TaughtInAlgebra2Grade6					{ get; set ; }
		public bool TaughtInAlgebra2Grade7					{ get; set ; }
		public bool TaughtInAlgebra2Grade8					{ get; set ; }
		public bool TaughtInAlgebra2Grade9					{ get; set ; }
		public bool TaughtInAlgebra2Grade10					{ get; set ; }
		public bool TaughtInAlgebra2Grade11					{ get; set ; }
		public bool TaughtInAlgebra2Grade12					{ get; set ; }
		public bool TaughtInAlgebra2College					{ get; set ; }	

		public int TaughtFactoringInPrecalculusYears		{ get; set; }
		public bool TaughtInPrecalculusGrade6				{ get; set ; }
		public bool TaughtInPrecalculusGrade7				{ get; set ; }
		public bool TaughtInPrecalculusGrade8				{ get; set ; }
		public bool TaughtInPrecalculusGrade9				{ get; set ; }
		public bool TaughtInPrecalculusGrade10				{ get; set ; }
		public bool TaughtInPrecalculusGrade11				{ get; set ; }
		public bool TaughtInPrecalculusGrade12				{ get; set ; }
		public bool TaughtInPrecalculusCollege				{ get; set ; }	

		public int TaughtFactoringInCalculusYears			{ get; set; }
		public bool TaughtInCalculusGrade6					{ get; set; }
		public bool TaughtInCalculusGrade7					{ get; set; }
		public bool TaughtInCalculusGrade8					{ get; set; }
		public bool TaughtInCalculusGrade9					{ get; set; }
		public bool TaughtInCalculusGrade10					{ get; set; }
		public bool TaughtInCalculusGrade11					{ get; set; }
		public bool TaughtInCalculusGrade12					{ get; set; }
		public bool TaughtInCalculusCollege					{ get; set; }	

		[MaxLength(50)]
		public string TaughtFactoringInOtherSpecified		{ get; set; }
		public int TaughtFactoringInOtherYears				{ get; set; }
		public bool TaughtInOtherGrade6						{ get; set; }
		public bool TaughtInOtherGrade7						{ get; set; }
		public bool TaughtInOtherGrade8						{ get; set; }
		public bool TaughtInOtherGrade9						{ get; set; }
		public bool TaughtInOtherGrade10					{ get; set; }
		public bool TaughtInOtherGrade11					{ get; set; }
		public bool TaughtInOtherGrade12					{ get; set; }
		public bool TaughtInOtherCollege					{ get; set; }	


		// Question 13

		public bool TeachingNowInAlgebra1Grade6				{ get; set; }
		public bool TeachingNowInAlgebra1Grade7				{ get; set; }
		public bool TeachingNowInAlgebra1Grade8				{ get; set; }
		public bool TeachingNowInAlgebra1Grade9				{ get; set; }
		public bool TeachingNowInAlgebra1Grade10			{ get; set; }
		public bool TeachingNowInAlgebra1Grade11			{ get; set; }
		public bool TeachingNowInAlgebra1Grade12			{ get; set; }
		public bool TeachingNowInAlgebra1College			{ get; set; } 

		public bool TeachingNowInAlgebra2Grade6				{ get; set; }
		public bool TeachingNowInAlgebra2Grade7				{ get; set; }
		public bool TeachingNowInAlgebra2Grade8				{ get; set; }
		public bool TeachingNowInAlgebra2Grade9				{ get; set; }
		public bool TeachingNowInAlgebra2Grade10			{ get; set; }
		public bool TeachingNowInAlgebra2Grade11			{ get; set; }
		public bool TeachingNowInAlgebra2Grade12			{ get; set; }
		public bool TeachingNowInAlgebra2College			{ get; set; } 

		public bool TeachingNowInPrecalculusGrade6			{ get; set; }
		public bool TeachingNowInPrecalculusGrade7			{ get; set; }
		public bool TeachingNowInPrecalculusGrade8			{ get; set; }
		public bool TeachingNowInPrecalculusGrade9			{ get; set; }
		public bool TeachingNowInPrecalculusGrade10			{ get; set; }
		public bool TeachingNowInPrecalculusGrade11			{ get; set; }
		public bool TeachingNowInPrecalculusGrade12			{ get; set; }
		public bool TeachingNowInPrecalculusCollege			{ get; set; } 

		public bool TeachingNowInCalculusGrade6				{ get; set; }
		public bool TeachingNowInCalculusGrade7				{ get; set; }
		public bool TeachingNowInCalculusGrade8				{ get; set; }
		public bool TeachingNowInCalculusGrade9				{ get; set; }
		public bool TeachingNowInCalculusGrade10			{ get; set; }
		public bool TeachingNowInCalculusGrade11			{ get; set; }
		public bool TeachingNowInCalculusGrade12			{ get; set; }
		public bool TeachingNowInCalculusCollege			{ get; set; } 

		public bool TeachingNowInOtherGrade6				{ get; set; }
		public bool TeachingNowInOtherGrade7				{ get; set; }
		public bool TeachingNowInOtherGrade8				{ get; set; }
		public bool TeachingNowInOtherGrade9				{ get; set; }
		public bool TeachingNowInOtherGrade10				{ get; set; }
		public bool TeachingNowInOtherGrade11				{ get; set; }
		public bool TeachingNowInOtherGrade12				{ get; set; }
		public bool TeachingNowInOtherCollege				{ get; set; } 
		[MaxLength(50)]
		public string TeachingNowInOtherSpecified			{ get; set ; }

		// Question 14
		public bool UsedMethodDiff2Squares					{ get; set; }
		public bool UsedMethodQuadraticFormula				{ get; set; }
		public bool UsedMethodGuessAndCheck					{ get; set; }
		public bool UsedMethodCompletingSquare				{ get; set; }
		public bool UsedMethodSquareOfBinomial				{ get; set; }
		public bool UsedMethodGrouping						{ get; set; }
		public bool UsedMethodCommonFactor					{ get; set; }
		public bool UsedMethodOther							{ get; set; }
		[MaxLength(50)]
		public string UsedMethodOtherSpecified				{ get; set; }

		// Question 15
		// 4-1 
		public int EvaluateMethodDiff2Squares				{ get; set; } = EnumOptions.EvalDontKnow;
		public int EvaluateMethodQuadraticFormula			{ get; set; } = EnumOptions.EvalDontKnow;
		public int EvaluateMethodGuessAndCheck				{ get; set; } = EnumOptions.EvalDontKnow;
		public int EvaluateMethodCompletingSquare			{ get; set; } = EnumOptions.EvalDontKnow;
		public int EvaluateMethodSquareOfBinomial			{ get; set; } = EnumOptions.EvalDontKnow;
		public int EvaluateMethodGrouping					{ get; set; } = EnumOptions.EvalDontKnow;
		public int EvaluateMethodCommonFactor				{ get; set; } = EnumOptions.EvalDontKnow;
		public int EvaluateMethodOther						{ get; set; } = EnumOptions.EvalDontKnow;
		[MaxLength(50)]
		public string EvaluateMethodOtherSpecified			{ get; set; }

		// Question 16
		public bool GraphsNotUsed							{ get; set; }
		public bool GraphsCheckSolutions					{ get; set; }
		public bool GraphsCheckWork							{ get; set; }
		public bool GraphsHelpGuess							{ get; set; }
		public bool GraphsZeroOfParabola					{ get; set; }
		public bool GraphsFindMinMax						{ get; set; }
		public bool GraphsShowConnections					{ get; set; }
		public bool GraphsOther								{ get; set; }
		[MaxLength(50)]
		public string RelateGraphsOtherSpecified			{ get; set; }



		// Question 17
		[MaxLength(MaxCommentLength)]
		public string MostChallengingPart					{ get; set; }

		// Question 18
		[MaxLength(MaxCommentLength)]
		public string WhatToAddToCurriculum					{ get; set; }

		// Question 19
		[MaxLength(MaxCommentLength)]
		public string WhatToRemoveFromCurriculum			{ get; set; }

		// Question 20
		[MaxLength(MaxCommentLength)]
		public string WhatIsSuccessfulTeaching				{ get; set; }

		// Question 21
		public int TeachingSuccess							{ get; set; } = 3;


		// Part 3

		// Question 22
		// 5 - 1
		public int ConfidentWithTechnology					{ get; set; } = 3;

		// Question 23
		public int CanTechnologyBeMoreEffective				{ get; set; } = 3;
		[MaxLength(MaxCommentLength)]
		public string CanTechnologyBeEffectiveComment		{ get; set; }

		// Question 24
		public int AccessToGraphingCalculator				{ get; set; } = 3;
		public int AccessToBlackboard						{ get; set; } = 3;
		public int AccessToIpad								{ get; set; } = 3;
		public int AccessToGames							{ get; set; } = 3;
		public int AccessToSmartBoards						{ get; set; } = 3;
		public int AccessToPresentationSoftware				{ get; set; } = 3;
		public int AccessToCloudSharing						{ get; set; } = 3;
		public int AccessToComputerizedTesting				{ get; set; } = 3;
		public int AccessToSocialMedia						{ get; set; } = 3;
		public int AccessToMultimediaProjector				{ get; set; } = 3;
		public int AccessToClassroomResponseSystem			{ get; set; } = 3;
		public int AccessToCAI								{ get; set; } = 3;
		public int AccessToOnlineProjects					{ get; set; } = 3;
		public int AccessToInformationVisualization			{ get; set; } = 3;
		public int AccessToOther							{ get; set; } = 3;
		[MaxLength(120)]
		public string AccessToOtherSpecified				{ get; set; }

		// Question 25
		public int IncorporateGraphingCalculator			{ get; set; } = 3;
		public int IncorporateBlackboard					{ get; set; } = 3;
		public int IncorporateIpad							{ get; set; } = 3;
		public int IncorporateGames							{ get; set; } = 3;
		public int IncorporateSmartBoards					{ get; set; } = 3;
		public int IncorporatePresentationSoftware			{ get; set; } = 3;
		public int IncorporateCloudSharing					{ get; set; } = 3;
		public int IncorporateComputerizedTesting			{ get; set; } = 3;
		public int IncorporateSocialMedia					{ get; set; } = 3;
		public int IncorporateMultimediaProjector			{ get; set; } = 3;
		public int IncorporateClassroomResponseSystem		{ get; set; } = 3;
		public int IncorporateCAI							{ get; set; } = 3;
		public int IncorporateOnlineProjects				{ get; set; } = 3;
		public int IncorporateInformationVisualization		{ get; set; } = 3;
		public int IncorporateOther							{ get; set; } = 3;
		[MaxLength(120)]
		public string IncorporateOtherSpecified				{ get; set; }

		// Question 26
		public int UseToDifferenceOfSquares					{ get; set; } = 3;
		public int UseToQuadraticFormula					{ get; set; } = 3;
		public int UseToGuessAndCheck						{ get; set; } = 3;
		public int UseToCompleteSquare						{ get; set; } = 3;
		public int UseToSquareOfBinomial					{ get; set; } = 3;
		public int UseToGrouping							{ get; set; } = 3;
		public int UseToCommonFactor						{ get; set; } = 3;
		public int UseToOther								{ get; set; } = 3;
		[MaxLength(120)]
		public string UseToOtherSpecified					{ get; set; }

		// Question 27
		public int GoalToComplyToPrincipal					{ get; set; } = 3;
		public int GoalToPresentProblems					{ get; set; } = 3;
		public int GoalToComputations						{ get; set; } = 3;
		public int GoalToGraph								{ get; set; } = 3;
		public int GoalToCheckAnswers						{ get; set; } = 3;
		public int GoalToStudentKnowledge					{ get; set; } = 3;
		public int GoalToCommunicate						{ get; set; } = 3;
		public int GoalToEngageStudents						{ get; set; } = 3;
		public int GoalToIndividualizeLearning				{ get; set; } = 3;
		public int GoalToDifferentReprentations				{ get; set; } = 3;
		public int GoalToTeachTechnology					{ get; set; } = 3;
		public int GoalToOther								{ get; set; } = 3;
		[MaxLength(120)]
		public string GoalToOtherSpecified					{ get; set; }

		[MaxLength(240)]
		public string  WhatCanTheyDoBetterWithTechnology	{ get; set; }
		[MaxLength(240)]
		public string  WhatCanTheyNotDoBetterWithTechnology	{ get; set; }
	}
}
