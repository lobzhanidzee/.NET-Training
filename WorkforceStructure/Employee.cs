namespace WorkforceStructure;

/// <summary>
/// Represents an employee.
/// </summary>
public class Employee
{
    private readonly string name;
    private decimal salary;
    private decimal bonus;

    /// <summary>
    /// Initializes a new instance of the <see cref="Employee"/> class with the specified name and salary.
    /// </summary>
    /// <param name="name">The name of the employee.</param>
    /// <param name="salary">The salary of the employee.</param>
    /// <exception cref="ArgumentNullException">Thrown when name is null.</exception>
    /// <exception cref="ArgumentOutOfRangeException">Thrown salary less than 0.</exception>
    public Employee(string name, decimal salary)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException("Name cannot be null, empty or whitespace.", nameof(name));
        }

        this.name = name;
        this.Salary = salary;
    }

    /// <summary>
    /// Gets the name of the employee.
    /// </summary>
    public string Name { get => this.name; }

    /// <summary>
    /// Gets or sets the salary of the employee.
    /// </summary>
    /// <exception cref="ArgumentOutOfRangeException">Thrown value less than 0.</exception>
    public decimal Salary
    {
        get => this.salary; set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(value), "Salary cannot be less than zero.");
            }

            this.salary = value;
        }
    }

    /// <summary>
    /// Assigns a bonus to the employee.
    /// </summary>
    /// <param name="bonus">The bonus amount.</param>
    /// <exception cref="ArgumentOutOfRangeException">Thrown bonus less than 0.</exception>
    public virtual void AssignBonus(decimal bonus)
    {
        ArgumentOutOfRangeException.ThrowIfNegative(bonus);

        this.bonus = bonus;
    }

    /// <summary>
    /// Calculates the total amount to be paid to the employee, including bonuses.
    /// </summary>
    /// <returns>The total amount to be paid to the employee.</returns>
    public decimal CalculateTotalPay()
    {
        return this.Salary + this.bonus;
    }

    /// <summary>
    /// Returns a string representation of the employee.
    /// </summary>
    /// <returns>A string that represents the employee.</returns>
    public override string ToString()
    {
        return $"{this.name}, Salary: {this.Salary:C2}, Bonus: {this.bonus:C2}";
    }
}
