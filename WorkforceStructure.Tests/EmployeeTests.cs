using System.Globalization;
using NUnit.Framework;
using static WorkforceStructure.Tests.TestHelper;

namespace WorkforceStructure.Tests;

[TestFixture]
public class EmployeeTests
{
    private Type classType = null!;

    private static readonly object[][] ValidConstructorData =
    [
        ["John Doe", 50000m],
        ["Jane Smith", 60000m],
        ["Alice Johnson", 70000m],
        ["Bob Brown", 80000m],
        ["Charlie White", 90000m],
        ["Diana Green", 100000m],
        ["Eve Black", 110000m],
        ["Frank Blue", 120000m]
    ];

    private static readonly object[][] ConstructorDataWithInvalidName =
    [
        [null!, 50000m, "name"],
        [string.Empty, 50000m, "name"],
        [" ", 50000m, "name"],
    ];

    private static readonly object[][] ConstructorDataWithInvalidSalary =
    [
        ["John Doe", -50000m, "value"],
        ["Jane Smith", -1m, "value"],
        ["Alice Johnson", decimal.MinValue, "value"]
    ];

    private static IEnumerable<TestCaseData> ToStringMethodData
    {
        get
        {
            yield return new TestCaseData(new Employee("John Doe", 50000m)).Returns("John Doe, Salary: ¤50,000.00, Bonus: ¤100.00");
            yield return new TestCaseData(new Employee("Jane Smith", 60000m)).Returns("Jane Smith, Salary: ¤60,000.00, Bonus: ¤100.00");
            yield return new TestCaseData(new Employee("Alice Johnson", 70000m)).Returns("Alice Johnson, Salary: ¤70,000.00, Bonus: ¤100.00");
            yield return new TestCaseData(new Employee("Bob Brown", 80000m)).Returns("Bob Brown, Salary: ¤80,000.00, Bonus: ¤100.00");
            yield return new TestCaseData(new Manager("John Doe", 50000m, 50)).Returns("John Doe, Salary: ¤50,000.00, Bonus: ¤100.00, Clients: 50");
            yield return new TestCaseData(new Manager("Jane Smith", 60000m, 120)).Returns("Jane Smith, Salary: ¤60,000.00, Bonus: ¤600.00, Clients: 120");
            yield return new TestCaseData(new Manager("Alice Johnson", 70000m, 200)).Returns("Alice Johnson, Salary: ¤70,000.00, Bonus: ¤1,100.00, Clients: 200");
            yield return new TestCaseData(new Manager("Bob Brown", 80000m, 0)).Returns("Bob Brown, Salary: ¤80,000.00, Bonus: ¤100.00, Clients: 0");
            yield return new TestCaseData(new SalesPerson("John Doe", 50000m, 50)).Returns("John Doe, Salary: ¤50,000.00, Bonus: ¤100.00, Sales Percentage: 50%");
            yield return new TestCaseData(new SalesPerson("Jane Smith", 60000m, 101)).Returns("Jane Smith, Salary: ¤60,000.00, Bonus: ¤200.00, Sales Percentage: 101%");
            yield return new TestCaseData(new SalesPerson("Alice Johnson", 70000m, 203)).Returns("Alice Johnson, Salary: ¤70,000.00, Bonus: ¤300.00, Sales Percentage: 203%");
            yield return new TestCaseData(new SalesPerson("Bob Brown", 80000m, 0)).Returns("Bob Brown, Salary: ¤80,000.00, Bonus: ¤100.00, Sales Percentage: 0%");
        }
    }

    [SetUp]
    public void SetUp()
    {
        this.classType = typeof(Employee);
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
    }

    [Test]
    public void Employee_Class_Is_Public()
    {
        AssertThatClassIsPublic(this.classType, false);
    }

    [Test]
    public void Employee_Inherits_Object()
    {
        AssertThatClassInheritsObject(this.classType, typeof(object));
    }

    [TestCase([typeof(string), typeof(decimal)])]
    public void Employee_Constructor_Exists(params Type[] parameterTypes)
    {
        AssertThatConstructorExists(this.classType, parameterTypes);
    }

    [TestCase("name", typeof(string))]
    [TestCase("salary", typeof(decimal))]
    [TestCase("bonus", typeof(decimal))]
    public void Employee_Field_Exists(string fieldName, Type fieldType)
    {
        AssertThatFieldExists(this.classType, fieldName, fieldType);
    }

    [TestCase("Name", typeof(string), true, false)]
    [TestCase("Salary", typeof(decimal), true, true)]
    public void Employee_Property_Exists(string propertyName, Type propertyType, bool canRead, bool canWrite)
    {
        AssertThatPropertyExists(this.classType, propertyName, propertyType, canRead, canWrite);
    }

    [TestCase("AssignBonus", typeof(void), true, false, typeof(decimal))]
    [TestCase("CalculateTotalPay", typeof(decimal), false, false)]
    public void Employee_Method_Exists(
        string methodName,
        Type returnType,
        bool isVirtual,
        bool isAbstract,
        params Type[] parameterTypes)
    {
        AssertThatMethodExists(this.classType, methodName, returnType, isVirtual, isAbstract, parameterTypes);
    }

    [TestCaseSource(nameof(ValidConstructorData))]
    public void Employee_ValidConstructor_InitializesProperties(string name, decimal salary)
    {
        var employee = new Employee(name, salary);
        Assert.Multiple(
            () =>
            {
                Assert.That(employee.Name, Is.EqualTo(name));
                Assert.That(employee.Salary, Is.EqualTo(salary));
            });
    }

    [TestCaseSource(nameof(ConstructorDataWithInvalidName))]
    public void Employee_InvalidConstructor_Throws_ArgumentException(string name, decimal salary, string parameterName)
    {
        var exception = Assert.Throws<ArgumentException>(() => new Employee(name, salary));
        Assert.That(exception!.ParamName, Is.EqualTo(parameterName));
        Assert.That(exception.Message, Is.EqualTo("Name cannot be null, empty or whitespace. (Parameter 'name')"));
    }

    [TestCaseSource(nameof(ConstructorDataWithInvalidSalary))]
    public void Employee_InvalidConstructor_Throws_ArgumentOutOfRangeException(
        string name,
        decimal salary,
        string parameterName)
    {
        var exception = Assert.Throws<ArgumentOutOfRangeException>(() => new Employee(name, salary));
        Assert.That(exception!.ParamName, Is.EqualTo(parameterName));
        Assert.That(exception.Message, Is.EqualTo("Salary cannot be less than zero. (Parameter 'value')"));
    }

    [TestCase(1000)]
    [TestCase(50)]
    [TestCase(0)]
    public void AssignBonus_ValidBonus_AssignsCorrectly(decimal bonus)
    {
        var employee = new Employee("John Doe", 50000m);
        employee.AssignBonus(bonus);
        Assert.That(employee.CalculateTotalPay(), Is.EqualTo(employee.Salary + bonus));
    }

    [TestCase(-1000)]
    public void AssignBonus_InvalidBonus_ThrowsArgumentOutOfRangeException(decimal bonus)
    {
        var employee = new Employee("John Doe", 50000m);
        _ = Assert.Throws<ArgumentOutOfRangeException>(() => employee.AssignBonus(bonus));
    }

    [TestCase(60000)]
    [TestCase(0)]
    public void Salary_ValidValue_SetsSalary(decimal salary)
    {
        var employee = new Employee("John Doe", 50000m) { Salary = salary };
        Assert.That(employee.Salary, Is.EqualTo(salary));
    }

    [TestCase(-1000)]
    public void Salary_InvalidValue_ThrowsArgumentOutOfRangeException(decimal salary)
    {
        var employee = new Employee("John Doe", 50000m);
        _ = Assert.Throws<ArgumentOutOfRangeException>(() => employee.Salary = salary);
    }

    [TestCaseSource(nameof(ToStringMethodData))]
    public string ToString_ReturnsExpectedFormat(Employee employee)
    {
        employee.AssignBonus(100m);
        return employee.ToString();
    }
}
