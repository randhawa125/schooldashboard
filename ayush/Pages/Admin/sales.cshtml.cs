using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ayush.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using static ayush.Services.SalesService;

namespace ayush.Pages.Admin
{
    public class salesModel : PageModel
    {
        private SalesService _salesService { get; set; }
        public salesModel(SalesService salesService)
        {
            _salesService = salesService;
        }

        public List<SaleViewModel> PlanOneSales { get; set; }
        public List<SaleViewModel> PlanTwoSales { get; set; }
        public List<SaleViewModel> PlanThreeSales { get; set; }
        public void OnGet()
        {
            PlanOneSales = _salesService.GetLastSixMonthSales(1);

            PlanTwoSales = _salesService.GetLastSixMonthSales(2);

            PlanThreeSales = _salesService.GetLastSixMonthSales(3);
        }
    }
}
