using ayush.Data;
using ayush.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ayush.Services
{
	public class GraphService
	{
		private ayushContext _context { get; set; }
		public GraphService(ayushContext context)
		{
			_context = context;
		}

		public async Task UpdateGraphModuleFour(int studentQuizId)
		{
			var studentQuiz = _context.StudentQuizzes.FirstOrDefault(x => x.Id == studentQuizId);
			var marks = await _context.StudentModuleFourMarks.FirstOrDefaultAsync(x => x.UserId == studentQuiz.UserId);
			if(marks == null)
			{
				marks = new StudentModuleFourMarks();
				marks.UserId = studentQuiz.UserId;
				_context.StudentModuleFourMarks.Add(marks);
			}
			if(studentQuiz.Quiz.Name == "Verbal Reasoning")
			{
				marks.VerbalReasoning = studentQuiz.Score;
				var zScore = (marks.VerbalReasoning - 16) / 6;
				var stenScore = (zScore * 2) + (decimal)5.5;
				marks.FinalStenVerbalReasoning = (int)Math.Round(stenScore, 2);
			}
			else if (studentQuiz.Quiz.Name == "Spatial Relations")
			{
				marks.SpatialReasoning = studentQuiz.Score;
				var zScore = (marks.SpatialReasoning - (decimal)10.5) / 4;
				var stenScore = (zScore * 2) + (decimal)5.5;
				marks.FinalStenSpatialReasoning = (int)Math.Round(stenScore, 2);
			}
			else if (studentQuiz.Quiz.Name == "Quantitative Reasoning")
			{
				marks.QuantitativeReasoning = studentQuiz.Score;
				var zScore = (marks.QuantitativeReasoning - (decimal)16) / 6;
				var stenScore = (zScore * 2) + (decimal)5.5;
				marks.FinalStenQuantitativeReasoning = (int)Math.Round(stenScore, 2);
			}
			else if (studentQuiz.Quiz.Name == "Perceptual Speed")
			{
				marks.PerceptualReasoning = studentQuiz.Score;
				var zScore = (marks.PerceptualReasoning - (decimal)10.5) / 4;
				var stenScore = (zScore * 2) + (decimal)5.5;
				marks.FinalStenPerceptualReasoning= (int)Math.Round(stenScore, 2);
			}
			else if (studentQuiz.Quiz.Name == "Mechanical Reasoning")
			{
				marks.MechanicalReasoning= studentQuiz.Score;
				var zScore = (marks.MechanicalReasoning - (decimal)11.1) / 4;
				var stenScore = (zScore * 2) + (decimal)5.5;
				marks.FinalStenMechanicalReasoning= (int)Math.Round(stenScore, 2);
			}
			else if (studentQuiz.Quiz.Name == "Critical Thinking")
			{
				marks.CriticalThinking= studentQuiz.Score;
				var zScore = (marks.CriticalThinking - (decimal)10.5) / 4;
				var stenScore = (zScore * 2) + (decimal)5.5;
				marks.FinalStenCriticalThinking= (int)Math.Round(stenScore, 2);
			}
			else if (studentQuiz.Quiz.Name == "Attention to Detail")
			{
				marks.AttentionToDetail = studentQuiz.Score;
				var zScore = (marks.AttentionToDetail - (decimal)10.5) / 4;
				var stenScore = (zScore * 2) + (decimal)5.5;
				marks.FinalStenAttentionToDetail = (int)Math.Round(stenScore, 2);
			}
			else if (studentQuiz.Quiz.Name == "Abstract Reasoning")
			{
				marks.AbstractReasoning = studentQuiz.Score;
				var zScore = (marks.AbstractReasoning - (decimal)10.5) / 4;
				var stenScore = (zScore * 2) + (decimal)5.5;
				marks.FinalStenAbstractReasoning= (int)Math.Round(stenScore, 2);
			}
			var sum = marks.VerbalReasoning + marks.CriticalThinking + marks.AbstractReasoning + marks.SpatialReasoning + marks.QuantitativeReasoning + marks.AttentionToDetail + marks.PerceptualReasoning + marks.MechanicalReasoning;
			var zScoreTotal = (sum - (decimal)92.6) / 37;
			var stenScoreTotal = (zScoreTotal * 2) + (decimal)5.5;
			marks.Total = (int)Math.Round(stenScoreTotal, 2);
			await _context.SaveChangesAsync();
		}

		//public decimal GetTotal(StudentModuleFourMarks marks)
		//{
		//	var sum_of_all = marks.VerbalReasoning + marks.CriticalThinking + marks.AbstractReasoning + marks.SpatialReasoning + marks.QuantitativeReasoning + marks.AttentionToDetail + marks.PerceptualReasoning + marks.MechanicalReasoning;
		//	var zScore = (sum_of_all - (decimal)92.6) / 37;
		//	var stenScore = (zScore * (decimal)2) + (decimal)5.5;
		//	return (int)Math.Round(stenScore);
		//}

		//public decimal GetFinalSten(decimal score)
		//{
		//	var zScore = (score - (decimal)11.1) / 4;
		//	var stenScore = (zScore * (decimal)2) + (decimal)5.5;
		//	int final = (int)Math.Round(stenScore);
		//	return final;
		//}
	}
}
