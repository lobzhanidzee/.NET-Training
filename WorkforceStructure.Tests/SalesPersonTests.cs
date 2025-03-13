using NUnit.Framework;
using static WorkforceStructure.Tests.TestHelper;

namespace WorkforceStructure.Tests;

[TestFixture]
public class SalesPersonTests
{
    private Type classType = null!;

    private static readonly object[][] ValidConstructorData =
    [
        ["John Doe", 50000m, 50], ["Jane Smith", 60000m, 90],
        ["Alice Johnson", 70000m, 100], ["Bob Brown", 80000m, 0],
        ["Charlie White", 90000m, 10], ["Diana Green", 100000m, 20],
        ["Eve Black", 110000m, 30], ["Frank Blue", 120000m, 40],
    ];

    private static readonly object[][] ConstructorDataWithInvalidName =
    [
        [null!, 50000m, 50, "name"], [string.Empty, 50000m, 50, "name"],
        [" ", 50000m, 50, "name"]
    ];

    private static readonly object[][] ConstructorDataWithInvalidSalary =
    [
        ["John Doe", -50000m, 50, "value"], ["Jane Smith", -1m, 50, "value"],
    ];

    private static readonly object[][] ConstructorDataWithInvalidSalesPercentage =
    [
        ["John Doe", 50000m, -50, "salesPercentage"],
        ["Jane Smith", 60000m, -120, "salesPercentage"]
    ];

    [SetUp]
    public void SetUp() => this.classType = typeof(SalesPerson);

    [Test]
    public void SalesPerson_Class_Is_Public() => AssertThatClassIsPublic(this.classType, false);

    [Test]
    public void SalesPerson_Inherits_Employee()
    {
        AssertThatClassInheritsObject(this.classType, typeof(Employee));
    }

    [TestCase("salesPercentage", typeof(int))]
    public void SalesPerson_Field_Exists(string fieldName, Type fieldType) =>
        AssertThatFieldExists(this.classType, fieldName, fieldType);

    [Test]
    public void SalesPerson_Constructor_Exists() =>
        AssertThatConstructorExists(this.classType, typeof(string), typeof(decimal), typeof(int));

    [TestCase("AssignBonus", typeof(void), true, false, typeof(decimal))]
    public void SalesPerson_Method_Exists(
        string methodName,
        Type returnType,
        bool isVirtual,
        bool isAbstract,
        params Type[] parameterTypes)
    {
        AssertThatMethodExists(this.classType, methodName, returnType, isVirtual, isAbstract, parameterTypes);
    }

    [TestCaseSource(nameof(ValidConstructorData))]
    public void SalesPerson_ValidConstructor_InitializesProperties(string name, decimal salary, int salesPercentage)
    {
        var salesPerson = new SalesPerson(name, salary, salesPercentage);
        Assert.Multiple(
            () =>
            {
                Assert.That(salesPerson.Name, Is.EqualTo(name));
                Assert.That(salesPerson.Salary, Is.EqualTo(salary));
            });
    }

    [TestCaseSource(nameof(ConstructorDataWithInvalidName))]
    public void SalesPerson_InvalidConstructor_Throws_ArgumentException(
        string name,
        decimal salary,
        int salesPercentage,
        string parameterName)
    {
        var exception = Assert.Throws<ArgumentException>(() => new SalesPerson(name, salary, salesPercentage));
        Assert.That(exception!.ParamName, Is.EqualTo(parameterName));
    }

    [TestCaseSource(nameof(ConstructorDataWithInvalidSalary))]
    public void SalesPerson_InvalidConstructor_Throws_ArgumentOutOfRangeException(
        string name,
        decimal salary,
        int salesPercentage,
        string parameterName)
    {
        var exception =
            Assert.Throws<ArgumentOutOfRangeException>(() => new SalesPerson(name, salary, salesPercentage));
        Assert.That(exception!.ParamName, Is.EqualTo(parameterName));
    }

    [TestCaseSource(nameof(ConstructorDataWithInvalidSalesPercentage))]
    public void SalesPerson_InvalidConstructor_Throws_ArgumentOutOfRangeException_SalesPercentage(
        string name,
        decimal salary,
        int salesPercentage,
        string parameterName)
    {
        var exception = Assert.Throws<ArgumentOutOfRangeException>(() => new SalesPerson(name, salary, salesPercentage));
        Assert.That(exception!.ParamName, Is.EqualTo(parameterName));
    }

    [TestCase(500, 500, 50)]
    [TestCase(500, 1000, 150)]
    [TestCase(500, 1500, 250)]
    public void AssignBonus_ValidBonus_AssignsCorrectly(
        decimal bonus,
        decimal expectedBonus,
        int salesPercentage)
    {
        var manager = new Manager("John Doe", 50000m, salesPercentage);
        manager.AssignBonus(bonus);
        Assert.That(manager.CalculateTotalPay(), Is.EqualTo(manager.Salary + expectedBonus));
    }

    [TestCase(-1000)]
    public void AssignBonus_InvalidBonus_ThrowsArgumentOutOfRangeException(decimal bonus)
    {
        var salesPerson = new SalesPerson("John Doe", 50000m, 50);
        Assert.Throws<ArgumentOutOfRangeException>(() => salesPerson.AssignBonus(bonus));
    }

    [TestCase(60000)]
    [TestCase(0)]
    public void Salary_ValidValue_SetsSalary(decimal salary)
    {
        var salesPerson = new SalesPerson("John Doe", 50000m, 50) { Salary = salary };
        Assert.That(salesPerson.Salary, Is.EqualTo(salary));
    }

    [TestCase(-1000)]
    public void Salary_InvalidValue_ThrowsArgumentOutOfRangeException(decimal salary)
    {
        var salesPerson = new SalesPerson("John Doe", 50000m, 50);
        Assert.Throws<ArgumentOutOfRangeException>(() => salesPerson.Salary = salary);
    }

    [Test]
    public void MultipleBonuses_AreAssignedCorrectly()
    {
        var salesPerson = new SalesPerson("John Doe", 50000m, 50);
        salesPerson.AssignBonus(1000);
        salesPerson.AssignBonus(2000);
        Assert.That(salesPerson.CalculateTotalPay(), Is.EqualTo(50000m + 2000));
    }

    [TestCase(500, 500, 50)]
    [TestCase(500, 1000, 150)]
    [TestCase(500, 1500, 250)]
    public void AssignBonus_MultipleBonuses_AreAssignedCorrectly(
        decimal bonus,
        decimal expectedBonus,
        int salesPercentage)
    {
        var manager = new Manager("John Doe", 50000m, salesPercentage);
        manager.AssignBonus(bonus);
        manager.AssignBonus(bonus);
        Assert.That(manager.CalculateTotalPay(), Is.EqualTo(manager.Salary + expectedBonus));
    }

    [Test]
    public void SalaryAndBonus_ZeroValues_AreHandledCorrectly()
    {
        var salesPerson = new SalesPerson("John Doe", 0m, 50);
        salesPerson.AssignBonus(0m);
        Assert.That(salesPerson.CalculateTotalPay(), Is.EqualTo(0m));
    }
}
