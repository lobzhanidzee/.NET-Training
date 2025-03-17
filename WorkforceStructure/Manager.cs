using System.Xml.Linq;

namespace WorkforceStructure;

/// <summary>
/// Represents a manager, a specialized type of employee.
/// </summary>
// TODO: Define the Manager class
public class Manager : Employee
{
    // TODO: Define the private field to store the client count
    private int clientCount;

    /// <summary>
    /// Initializes a new instance of the <see cref="Manager"/> class with the specified name, salary, and client count.
    /// </summary>
    /// <param name="name">The name of the manager.</param>
    /// <param name="salary">The salary of the manager.</param>
    /// <param name="clientCount">The number of clients managed by the manager.</param>
    /// <exception cref="ArgumentNullException">Thrown when name is null.</exception>
    /// <exception cref="ArgumentOutOfRangeException">Thrown salary less than 0.</exception>
    /// <exception cref="ArgumentOutOfRangeException">Thrown clientCount less than 0.</exception>
    // TODO: Implement the constructor logic
    public Manager(string name, int salary, int clientCount)
    : base(name, salary)
    {
        this.clientCount = clientCount;
    }

    /// <summary>
    /// Assigns a bonus to the manager based on the number of clients managed.
    /// </summary>
    /// <param name="bonus">The base bonus amount.</param>
    /// <exception cref="ArgumentOutOfRangeException">Thrown bonus less than 0.</exception>
    // TODO: Implement the AssignBonus method
    public int AssignBonus()
    {
        if (this.clientCount > 150)
        {
            return 1000;
        }
        else if (this.clientCount > 100)
        {
            return 500;
        }
        else
        {
            return 0;
        }
    }

    /// <summary>
    /// Returns a string representation of the manager.
    /// </summary>
    /// <returns>A string that represents the manager.</returns>
    // TODO: Implement the ToString method
    public override string ToString()
    {
        return base.ToString();
    }

}
