using ayush.Data;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace ayush.Services
{
	public class SalesService
	{
		private ayushContext _context { get; set; }
		public SalesService(ayushContext context)
		{
			_context = context;
		}

		public List<SaleViewModel> GetLastSixMonthSales(int planId)
		{
			var sales = new List<SaleViewModel>();

			for(int i = 5; i >= 0; i--)
			{
				var startDate = DateTime.Today.AddDays(-(DateTime.Now.Day - 1)).AddMonths(-i);
				
				var endDate = startDate.AddMonths(1).AddDays(-1);
				
				var sale = new SaleViewModel()
				{
					Month = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(startDate.Month),
					Sale = GetSalesFromStartAndEndDate(planId, startDate, endDate)
				};

				sales.Add(sale);
			}

			return sales;
		}

		private int GetSalesFromStartAndEndDate(int planId, DateTime startDate, DateTime enddate)
		{
			return _context.UserInformation.Count(x => x.PlanId == planId && x.PlanPurchaseDate >= startDate && x.PlanPurchaseDate <= enddate);
		}

		public class SaleViewModel
		{
			public string Month { get; set; }
			public int Sale { get; set; }
		}
	}
}
