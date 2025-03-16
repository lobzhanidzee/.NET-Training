namespace WorkforceStructure;

/// <summary>
/// Represents an employee.
/// </summary>
// TODO: Define the Employee class
public class Employee
{
    // TODO: Define the private fields to store the name, salary, and bonus
    private string name;
    private int salary;

    /// <summary>
    /// Initializes a new instance of the <see cref="Employee"/> class with the specified name and salary.
    /// </summary>
    /// <param name="name">The name of the employee.</param>
    /// <param name="salary">The salary of the employee.</param>
    /// <exception cref="ArgumentNullException">Thrown when name is null.</exception>
    /// <exception cref="ArgumentOutOfRangeException">Thrown salary less than 0.</exception>
    // TODO: Implement the constructor logic
    public Employee(string name, int salary)
    {
        this.Name = name;
        this.Salary = salary;
    }

    /// <summary>
    /// Gets the name of the employee.
    /// </summary>
    // TODO: Implement the Name property
    public string Name { get => this.name; set => this.name = value; }

    /// <summary>
    /// Gets or sets the salary of the employee.
    /// </summary>
    /// <exception cref="ArgumentOutOfRangeException">Thrown value less than 0.</exception>
    // TODO: Implement the Salary property
    public int Salary { get => this.salary; set => this.salary = value; }


    /// <summary>
    /// Assigns a bonus to the employee.
    /// </summary>
    /// <param name="bonus">The bonus amount.</param>
    /// <exception cref="ArgumentOutOfRangeException">Thrown bonus less than 0.</exception>
    // TODO: Implement the AssignBonus method
    public void AssingBonus() { }


    /// <summary>
    /// Calculates the total amount to be paid to the employee, including bonuses.
    /// </summary>
    /// <returns>The total amount to be paid to the employee.</returns>
    // TODO: Implement the CalculateTotalPay method
    public void CalculateTotalPay() { }

    /// <summary>
    /// Returns a string representation of the employee.
    /// </summary>
    /// <returns>A string that represents the employee.</returns>
    // TODO: Implement the ToString method
    public override string ToString()
    {
        return $"{this.Name}, Salary: {this.Salary}";
    }
}
