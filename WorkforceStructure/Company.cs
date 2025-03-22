namespace WorkforceStructure;

/// <summary>
/// Represents a company with a list of employees.
/// </summary>
// TODO: Define the Company class
public class Company
{
    // TODO: Define the private field to store the list of employees
    private Employee[] employees;

    /// <summary>
    /// Initializes a new instance of the <see cref="Company"/> class with the specified employees.
    /// </summary>
    /// <param name="employees">The employees of the company.</param>
    /// <exception cref="ArgumentNullException">Thrown when employees is null.</exception>
    // TODO: Implement the constructor logic
    public Company(Employee[] employees)
    {
        this.employees = employees;
    }

    /// <summary>
    /// Distributes the specified bonus amount to all employees.
    /// </summary>
    /// <param name="companyBonus">The bonus amount to distribute to each employee.</param>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when companyBonus is less than zero.</exception>
    // TODO: Implement the DistributeBonuses method
    public void DistributeBonuses(decimal companyBonus)
    {
        foreach (var employee in this.employees)
        {
            employee.AssignBonus(companyBonus);
        }
    }

    /// <summary>
    /// Calculates the total amount to be paid to all employees, including bonuses.
    /// </summary>
    /// <returns>The total amount to be paid to all employees.</returns>
    // TODO: Implement the CalculateTotalPayroll method
    public decimal CalculateTotalPayroll()
    {
        decimal result = 0;
        foreach (var employee in this.employees)
        {
            result += employee.Salary;
        }

        return result;
    }

    /// <summary>
    /// Gets the name of the employee with the highest salary.
    /// </summary>
    /// <returns>The name of the employee with the highest salary.</returns>
    /// <exception cref="InvalidOperationException">Thrown when there are no employees in the company.</exception>
    // TODO: Implement the GetHighestPaidEmployeeName method
    public string GetHighestPaidEmployeeName()
    {
        Employee result = this.employees[0];

        for (var i = 1; i < this.employees.Length; i++)
        {
            if (this.employees[i].Salary > result.Salary)
            {
                result = this.employees[i];
            }
        }

        return result.Name;
    }
}
