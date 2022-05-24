namespace WebApplication3_1.Properties.Services
{
    public class SalaryCalculatorModified : ISalaryCalculator
    {
        public double CalculateSallary(double SalaryForHour, double Procent,int Hours)
        {
            var totalSalary = SalaryForHour * Hours;
            var minusSalary = totalSalary / 100;
            totalSalary = totalSalary - minusSalary;
            //totalSalary = (totalSalary * Procent);
            return totalSalary;
        }
         
        public double CalculateSallaryWithoutProcent(double SalaryForHour, int Hours)
        {
            var totalSalary = SalaryForHour * Hours;
            return totalSalary;
        }

    }
}
