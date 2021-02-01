using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Ch02FutureValueWertz.Models
{
    public class FutureValueModel
    {
        [Required(ErrorMessage = "Please enter a valid number for the monthly investment")]
        [Range(1, 500, ErrorMessage = "Please enter a monthly investment between 1 and 500")]
        public decimal? MonthlyInvestment { get; set; }
        [Required(ErrorMessage = "Please enter a valid number for the yearly interest rate")]
        [Range(0,10, ErrorMessage = "Please enter a yearly interest rate between 0 and 10")]
        public decimal? YearlyInterestRate { get; set; }
        [Required(ErrorMessage = "Please enter a valid number for the number of years")]
        [Range(1,100, ErrorMessage = "Please enter a year between 1 and 100")]
        public int? Years { get; set; }
        public decimal CalculateFutureValue()
        {
            int months = Years.Value * 12;
            decimal monthlyInterestRate = YearlyInterestRate.Value / 12 / 100;
            decimal futureValue = 0;
            for (int i = 0; i < months; i++)
            {
                futureValue = (futureValue + MonthlyInvestment.Value) * (1 + monthlyInterestRate);
            }
            return futureValue;
        }
    }
}
