namespace WorkforceStructure;

/// <summary>
/// Represents a salesperson, a specialized type of employee.
/// </summary>
// TODO: Define the SalesPerson class
public class SalesPerson : Employee
{
    // TODO: Define the private field to store the sales percentage
    private int salesPercentage;

    /// <summary>
    /// Initializes a new instance of the <see cref="SalesPerson"/> class with the specified name, salary, and sales percentage.
    /// </summary>
    /// <param name="name">The name of the salesperson.</param>
    /// <param name="salary">The salary of the salesperson.</param>
    /// <param name="salesPercentage">The sales percentage achieved by the salesperson.</param>
    /// <exception cref="ArgumentNullException">Thrown when name is null.</exception>
    /// <exception cref="ArgumentOutOfRangeException">Thrown salary less than 0.</exception>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when salesPercentage is less than 0.</exception>
    // TODO: Implement the constructor logic
    public SalesPerson(string name, int salary, int salesPercentage)
        : base(name, salary)
    {
        this.salesPercentage = salesPercentage;
    }

    /// <summary>
    /// Assigns a bonus to the salesperson based on the sales percentage achieved.
    /// </summary>
    /// <param name="bonus">The base bonus amount.</param>
    /// <exception cref="ArgumentOutOfRangeException">Thrown bonus less than 0.</exception>
    // TODO: Implement the AssignBonus method
    public int AssignBonus()
    {
        return this.salesPercentage > 200 ? this.Salary * 3 : this.Salary * 2;
    }

    /// <summary>
    /// Returns a string representation of the salesperson.
    /// </summary>
    /// <returns>A string that represents the salesperson.</returns>
    // TODO: Implement the ToString method
}
