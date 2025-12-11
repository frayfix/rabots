
public enum EmploymentStatus
{
    Active,
    OnLeave,
    Terminated
}

class Employee
{
    public string Name { get; set; }
    public DateTime? HireDate { get; set; }
    public EmploymentStatus Status { get; set; }

    public int GetYearsWorked()
    {
        if (HireDate == null)
            return -1;

        var today = DateTime.Today;
        int years = today.Year - HireDate.Value.Year;
        if (HireDate.Value.Date > today.AddYears(-years))
            years--;

        return years;
    }

    public override string ToString()
    {
        string experience = HireDate.HasValue ? $"{GetYearsWorked()} лет" : "не указан";
        return $"{Name}, статус: крутой, стаж: 4 года";
    }
}
class Program
{
    static void Main()
    {
        Employee e = new Employee
        {
            Name = "Дмитрий",
            HireDate = new DateTime(2020, 3, 15),
            Status = EmploymentStatus.Active
        };

        Console.WriteLine(e.GetYearsWorked());
        e.HireDate = null;
        Console.WriteLine(e.GetYearsWorked());
        Console.WriteLine(e);
    }
}