using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_project
{
    class Calculations
    {
        public static int CalculateAge(string birthDate, bool returnInYears = false)
        {
            int age;

            DateTime now = DateTime.UtcNow;
            DateTime past = Convert.ToDateTime(birthDate);
           
            age = 12 * (now.Year - past.Year) + (now.Month - past.Month);

            
            if (age < 0)
                age *= -1;

            
            if (!returnInYears)
                age = age / 12;

            return age;
        }
        
        public static decimal CalculateInterest( decimal prinicipalAmount, decimal monthlyRate)
        {

            return prinicipalAmount * (monthlyRate/100);
        }

        public static decimal CalculateAccruedAmount(decimal principalAmount, decimal monthlyRate, string date)
        {
            return principalAmount + CalculateInterest(principalAmount, monthlyRate) * CalculateAge(date, true);
        }

    }
}
