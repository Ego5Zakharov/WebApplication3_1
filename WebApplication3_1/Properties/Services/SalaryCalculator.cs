namespace WebApplication3_1.Properties.Services
{
    public class SalaryCalculator
    {
        public double SalaryForHour { get; set; }
        public double Procent { get; set; }
        public int Hours { get; set; }

        public SalaryCalculator(double salaryForHour, double procent, int hours)
        {
            SalaryForHour = salaryForHour;
            Procent = procent;
            Hours = hours;
        }

        public SalaryCalculator(double salaryForHour,  int hours)
        {
            SalaryForHour = salaryForHour;
            Hours = hours;
        }
        public double GetSalary()
        {
            var SalaryCalculator = new SalaryCalculatorModified();
            return SalaryCalculator.CalculateSallaryWithoutProcent(SalaryForHour,Hours);
        }
        public double GetSalaryWithoutProcent()
        {
            var SalaryCalculator = new SalaryCalculatorModified();
            return SalaryCalculator.CalculateSallary(SalaryForHour,Procent,Hours);
        }
    }
}
