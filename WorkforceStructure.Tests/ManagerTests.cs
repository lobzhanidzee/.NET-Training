using NUnit.Framework;
using static WorkforceStructure.Tests.TestHelper;

namespace WorkforceStructure.Tests;

[TestFixture]
public class ManagerTests
{
    private Type classType = null!;

    private static readonly object[][] ValidConstructorData =
    [
        ["John Doe", 50000m, 50],
        ["Jane Smith", 60000m, 120],
        ["Alice Johnson", 70000m, 200],
        ["Bob Brown", 80000m, 0],
        ["Charlie White", 90000m, 151],
        ["Diana Green", 100000m, 99],
        ["Eve Black", 110000m, 101],
        ["Frank Blue", 120000m, 100],
    ];

    private static readonly object[][] ConstructorDataWithInvalidName =
    [
        [null!, 50000m, 50, "name"],
        [string.Empty, 50000m, 50, "name"],
        [" ", 50000m, 50, "name"],
    ];

    private static readonly object[][] ConstructorDataWithInvalidSalary =
    [
        ["John Doe", -50000m, 50, "value"],
        ["Jane Smith", -1m, 50, "value"],
    ];

    private static readonly object[][] ConstructorDataWithInvalidClientCount =
    [
        ["John Doe", 50000m, -50, "clientCount"],
        ["Jane Smith", 1m, -100, "clientCount"],
    ];

    [SetUp]
    public void SetUp() => this.classType = typeof(Manager);

    [Test]
    public void Manager_Class_Is_Public() => AssertThatClassIsPublic(this.classType, false);

    [Test]
    public void Manager_Inherits_Employee() => AssertThatClassInheritsObject(this.classType, typeof(Employee));

    [TestCase("clientCount", typeof(int))]
    public void Manager_Field_Exists(string fieldName, Type fieldType) =>
        AssertThatFieldExists(this.classType, fieldName, fieldType);

    [Test]
    public void Manager_Constructor_Exists() =>
        AssertThatConstructorExists(this.classType, typeof(string), typeof(decimal), typeof(int));

    [TestCase("AssignBonus", typeof(void), true, false, typeof(decimal))]
    public void Manager_Method_Exists(
        string methodName,
        Type returnType,
        bool isVirtual,
        bool isAbstract,
        params Type[] parameterTypes)
    {
        AssertThatMethodExists(this.classType, methodName, returnType, isVirtual, isAbstract, parameterTypes);
    }

    [TestCaseSource(nameof(ValidConstructorData))]
    public void Manager_ValidConstructor_InitializesProperties(string name, decimal salary, int clientCount)
    {
        var manager = new Manager(name, salary, clientCount);
        Assert.Multiple(
            () =>
            {
                Assert.That(manager.Name, Is.EqualTo(name));
                Assert.That(manager.Salary, Is.EqualTo(salary));
            });
    }

    [TestCaseSource(nameof(ConstructorDataWithInvalidName))]
    public void Manager_InvalidConstructor_Throws_ArgumentException(
        string name,
        decimal salary,
        int clientCount,
        string parameterName)
    {
        var exception = Assert.Throws<ArgumentException>(() => new Manager(name, salary, clientCount));
        Assert.That(exception!.ParamName, Is.EqualTo(parameterName));
    }

    [TestCaseSource(nameof(ConstructorDataWithInvalidSalary))]
    public void Manager_InvalidConstructor_Throws_ArgumentOutOfRangeException(
        string name,
        decimal salary,
        int clientCount,
        string parameterName)
    {
        var exception = Assert.Throws<ArgumentOutOfRangeException>(() => new Manager(name, salary, clientCount));
        Assert.That(exception!.ParamName, Is.EqualTo(parameterName));
    }

    [TestCaseSource(nameof(ConstructorDataWithInvalidClientCount))]
    public void Manager_InvalidConstructor_Throws_ArgumentOutOfRangeException_ClientCount(
        string name,
        decimal salary,
        int clientCount,
        string parameterName)
    {
        var exception = Assert.Throws<ArgumentOutOfRangeException>(() => new Manager(name, salary, clientCount));
        Assert.That(exception!.ParamName, Is.EqualTo(parameterName));
    }

    [TestCase(500, 1500, 160)]
    [TestCase(500, 1000, 120)]
    [TestCase(500, 500, 50)]
    public void AssignBonus_ValidBonus_AssignsCorrectly(
        decimal bonus,
        decimal expectedBonus,
        int clientCount)
    {
        var manager = new Manager("John Doe", 50000m, clientCount);
        manager.AssignBonus(bonus);
        Assert.That(manager.CalculateTotalPay(), Is.EqualTo(manager.Salary + expectedBonus));
    }

    [TestCase(-1000)]
    [TestCase(-10)]
    public void AssignBonus_InvalidBonus_ThrowsArgumentOutOfRangeException(decimal bonus)
    {
        var manager = new Manager("John Doe", 50000m, 50);
        Assert.Throws<ArgumentOutOfRangeException>(() => manager.AssignBonus(bonus));
    }

    [TestCase(60000)]
    [TestCase(0)]
    public void Salary_ValidValue_SetsSalary(decimal salary)
    {
        var manager = new Manager("John Doe", 50000m, 50) { Salary = salary };
        Assert.That(manager.Salary, Is.EqualTo(salary));
    }

    [TestCase(-1000)]
    public void Salary_InvalidValue_ThrowsArgumentOutOfRangeException(decimal salary)
    {
        var manager = new Manager("John Doe", 50000m, 50);
        Assert.Throws<ArgumentOutOfRangeException>(() => manager.Salary = salary);
    }

    [Test]
    public void MultipleBonuses_AreAssignedCorrectly()
    {
        var manager = new Manager("John Doe", 50000m, 50);
        manager.AssignBonus(1000);
        manager.AssignBonus(2000);
        Assert.That(manager.CalculateTotalPay(), Is.EqualTo(50000m + 2000));
    }
}
