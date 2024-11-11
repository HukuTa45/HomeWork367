public class Employee
{
    public string name { get; set; }
    public decimal zarplata { get; set; }
    public int HoursWorked { get; set; }
    public bool hourlyEmployee { get; set; }
}

public class TaxCalculator
{
    public decimal CalculateTax(Employee employee)
    {
        decimal nalog = 0;

        if (employee.hourlyEmployee)
        {

            nalog = 0.15m;
            return employee.HoursWorked * 20 * nalog;
        }
        else
        {
            nalog = 0.25m;
            return employee.zarplata * nalog;
        }
    }
}
