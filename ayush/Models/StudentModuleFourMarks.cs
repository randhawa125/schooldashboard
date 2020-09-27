using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ayush.Models
{
	public class StudentModuleFourMarks
	{
		public int Id { get; set; }
		public string UserId { get; set; }
		public decimal VerbalReasoning { get; set; }
		public decimal CriticalThinking { get; set; }
		public decimal AbstractReasoning { get; set; }
		public decimal SpatialReasoning { get; set; }
		public decimal QuantitativeReasoning { get; set; }
		public decimal AttentionToDetail { get; set; }
		public decimal PerceptualReasoning { get; set; }
		public decimal MechanicalReasoning { get; set; }
		public decimal FinalStenVerbalReasoning { get; set; }
		public decimal FinalStenCriticalThinking { get; set; }
		public decimal FinalStenAbstractReasoning { get; set; }
		public decimal FinalStenSpatialReasoning { get; set; }
		public decimal FinalStenQuantitativeReasoning { get; set; }
		public decimal FinalStenAttentionToDetail { get; set; }
		public decimal FinalStenPerceptualReasoning { get; set; }
		public decimal FinalStenMechanicalReasoning { get; set; }
		public decimal Total { get; set; }
	}
}
