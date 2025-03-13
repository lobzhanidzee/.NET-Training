# Employee Management System

Estimated time to complete the task: 1 hour

Prerequisites: .NET 8 SDK installed


## Task Description

In this task, you have to implement a class that represents different types of employees and a company that manages them. Each employee type has specific attributes and behaviors:

1. `Employee`: A general employee with a name, salary, and bonus.
2. `Manager`: A specialized employee who manages clients and receives additional bonuses based on the number of clients.
3. `SalesPerson`: A specialized employee who achieves sales and receives bonuses based on sales percentages.
4. `Company`: Manages a collection of employees, distributes bonuses, calculates total payroll, and identifies the highest-paid employee.

Each class has specific attributes and behavior described below:

| **Class**        | **Member**          | **Type**     | **Description**                                                                                     |
|------------------|---------------------|--------------|-----------------------------------------------------------------------------------------------------|
| **Employee**     | `name`              | Field        | Stores the name of the employee.                                                                     |
|                  | `salary`            | Field        | Stores the salary of the employee.                                                                   |
|                  | `bonus`             | Field        | Stores the bonus of the employee.                                                                    |
|                  | `Employee`          | Constructor  | Initializes the employee with a name and salary.                                                     |
|                  | `Name`              | Property     | Read-only property to get the name of the employee.                                                  |
|                  | `Salary`            | Property     | Read-write property to get and set the salary of the employee.                                       |
|                  | `AssignBonus`       | Method       | Assigns a bonus to the employee.                                                                     |
|                  | `CalculateTotalPay` | Method       | Calculates the total amount to be paid to the employee, including bonuses.                           |
|                  | `ToString`          | Method       | Returns a string representation of the employee in the format: |
| **Manager**      | `clientCount`       | Field        | Stores the number of clients managed by the manager.                                                |
|                  | `Manager`           | Constructor  | Initializes the manager with a name, salary, and client count.                                      |
|                  | `AssignBonus`       | Method       | Assigns a bonus to the manager based on the number of clients managed.                              |
|                  | `ToString`          | Method       | Returns a string representation of the manager in the format: |
| **SalesPerson**  | `salesPercentage`   | Field        | Stores the sales percentage achieved by the salesperson.                                            |
|                  | `SalesPerson`       | Constructor  | Initializes the salesperson with a name, salary, and sales percentage.                              |
|                  | `AssignBonus`       | Method       | Assigns a bonus to the salesperson based on the sales percentage achieved.                          |
|                  | `ToString`          | Method       | Returns a string representation of the salesperson in the format: |
| **Company**      | `employees`         | Field        | Stores the list of employees in the company.                                                        |
|                  | `Company`           | Constructor  | Initializes the company with a list of employees.                                                   |
|                  | `DistributeBonuses` | Method       | Distributes the specified bonus amount to all employees.                                            |
|                  | `CalculateTotalPayroll` | Method    | Calculates the total amount to be paid to all employees, including bonuses.                          |
|                  | `GetHighestPaidEmployeeName` | Method | Gets the name of the employee with the highest salary.                                               |

**Note** 
_The solution will not compile until all required types with required members are declared.  For a smoother development experience, we recommend initially declaring all necessary types and creating "stub methods" as follows:_ 
 
```csharp 
public returnType MethodName(parameters list) 
{ 
    throw new NotImplementedException(); 
} 
``` 
 
_This approach allows you to build and run your project incrementally while implementing each method._ 