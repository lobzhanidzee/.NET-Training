namespace WorkforceStructure;

/// <summary>
/// Represents a manager, a specialized type of employee.
/// </summary>
public class Manager : Employee
{
    private readonly int clientCount;

    /// <summary>
    /// Initializes a new instance of the <see cref="Manager"/> class with the specified name, salary, and client count.
    /// </summary>
    /// <param name="name">The name of the manager.</param>
    /// <param name="salary">The salary of the manager.</param>
    /// <param name="clientCount">The number of clients managed by the manager.</param>
    /// <exception cref="ArgumentNullException">Thrown when name is null.</exception>
    /// <exception cref="ArgumentOutOfRangeException">Thrown salary less than 0.</exception>
    /// <exception cref="ArgumentOutOfRangeException">Thrown clientCount less than 0.</exception>
    public Manager(string name, decimal salary, int clientCount)
    : base(name, salary)
    {
        ArgumentOutOfRangeException.ThrowIfLessThan(clientCount, 0);

        this.clientCount = clientCount;
    }

    /// <summary>
    /// Assigns a bonus to the manager based on the number of clients managed.
    /// </summary>
    /// <param name="bonus">The base bonus amount.</param>
    /// <exception cref="ArgumentOutOfRangeException">Thrown bonus less than 0.</exception>
    public override void AssignBonus(decimal bonus)
    {
        ArgumentOutOfRangeException.ThrowIfNegative(bonus);

        if (this.clientCount > 150)
        {
            base.AssignBonus(bonus + 1000);
        }
        else if (this.clientCount > 100)
        {
            base.AssignBonus(bonus + 500);
        }
        else
        {
            base.AssignBonus(bonus);
        }
    }

    /// <summary>
    /// Returns a string representation of the manager.
    /// </summary>
    /// <returns>A string that represents the manager.</returns>
    public override string ToString()
    {
        return $"{base.ToString()}, Clients: {this.clientCount}";
    }
}
