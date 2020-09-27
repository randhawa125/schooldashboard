using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ayush.Models
{
	public class PassiveCareer
	{
		public int Id { get; set; }
		public ListType CareerListType { get; set; }
		public string Name { get; set; }
		public string ImageUrl { get; set; }
		public string PersonalityFactors { get; set; }
		public string AptitudeFactors { get; set; }
		public string EQFactors { get; set; }
		public string InterestFactors { get; set; }
		public string MotivatorFactors { get; set; }
		public string StenPersonalityFactors { get; set; }
		public string StenAptitudeFactors { get; set; }
		public string StenEQFactors { get; set; }
		public string StenMotivatorFactors { get; set; }
		public string StenInterestFactors { get; set; }
		public decimal PersonalityStenConstant1 { get; set; }
		public decimal PersonalityStenConstant2 { get; set; }
		public decimal PersonalityStenConstant3 { get; set; }
		public decimal PersonalityStenConstant4 { get; set; }
		public decimal AptitudeStenConstant1 { get; set; }
		public decimal AptitudeStenConstant2 { get; set; }
		public decimal AptitudeStenConstant3 { get; set; }
		public decimal AptitudeStenConstant4 { get; set; }
		public decimal EQStenConstant1 { get; set; }
		public decimal EQStenConstant2 { get; set; }
		public decimal EQStenConstant3 { get; set; }
		public decimal EQStenConstant4 { get; set; }
		public decimal InterestStenConstant1 { get; set; }
		public decimal InterestStenConstant2 { get; set; }
		public decimal InterestStenConstant3 { get; set; }
		public decimal InterestStenConstant4 { get; set; }
		public decimal MotivatorStenConstant1 { get; set; }
		public decimal MotivatorStenConstant2 { get; set; }
		public decimal MotivatorStenConstant3 { get; set; }
		public decimal MotivatorStenConstant4 { get; set; }

		public enum ListType
		{
			ListA = 1,
			ListB = 2
		}
	}
}
