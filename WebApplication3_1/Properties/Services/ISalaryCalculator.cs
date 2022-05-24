namespace WebApplication3_1.Properties.Services
{
    public interface ISalaryCalculator
    {
        public double CalculateSallary(double SalaryForHour, double Procent, int Hours);
        public double CalculateSallaryWithoutProcent(double SalaryForHour, int Hours);
    }
}
