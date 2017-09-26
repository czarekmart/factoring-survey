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
		public bool TookNone								{ get; set; }

		public int YearsOfTeachingMath						{ get; set; } 

		public bool TaughtAge12								{ get; set ; }
		public bool TaughtAge13								{ get; set ; }
		public bool TaughtAge14								{ get; set ; }
		public bool TaughtAge15								{ get; set ; }
		public bool TaughtAge16								{ get; set ; }
		public bool TaughtAge17								{ get; set ; }
		public bool TaughtAge18								{ get; set ; }
		public bool TaughtAge19								{ get; set ; }
		public bool TaughtAgeNone							{ get; set ; }

		public bool TeachingAge12							{ get; set ; }
		public bool TeachingAge13							{ get; set ; }
		public bool TeachingAge14							{ get; set ; }
		public bool TeachingAge15							{ get; set ; }
		public bool TeachingAge16							{ get; set ; }
		public bool TeachingAge17							{ get; set ; }
		public bool TeachingAge18							{ get; set ; }
		public bool TeachingAge19							{ get; set ; }
		public bool TeachingAgeNone							{ get; set ; }

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

		[MaxLength(MaxCommentLength)]
		public string MostChallengingPart					{ get; set; }

		[MaxLength(MaxCommentLength)]
		public string WhatToAddToCurriculum					{ get; set; }

		[MaxLength(MaxCommentLength)]
		public string WhatToRemoveFromCurriculum			{ get; set; }

		[MaxLength(MaxCommentLength)]
		public string WhatIsSuccessfulTeaching				{ get; set; }

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
		[MaxLength(240)]
		public string  AdditionalComment					{ get; set; }
	}
}
