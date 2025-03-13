using NUnit.Framework;
using static WorkforceStructure.Tests.TestHelper;

namespace WorkforceStructure.Tests;

[TestFixture]
public class CompanyTests
{
    private Type classType = null!;

    private static readonly Employee[] Employees =
    [
        new Employee("John Doe", 50000m),
        new Employee("Jane Smith", 60000m),
        new Manager("Charlie White", 90000m, 151),
        new Manager("Jane Smith", 60000m, 120),
        new Manager("Alice Johnson", 70000m, 200),
        new SalesPerson("John Doe", 1000m, 0),
        new SalesPerson("Charlie White", 90000m, 151),
        new SalesPerson("Alice Johnson", 70000m, 203),
    ];

    private static readonly object[][] InvalidBonusData =
    [
        [Employees, -1000m],
        [Employees, -2000m]
    ];

    private static IEnumerable<TestCaseData> ValidBonusData
    {
        get
        {
            yield return new TestCaseData(Employees, 10m, new decimal[] { 10, 10, 1010, 510, 1010, 10, 20, 30 });
            yield return new TestCaseData(Employees, 300m, new decimal[] { 300, 300, 1300, 800, 1300, 300, 600, 900 });
            yield return new TestCaseData(Employees, 500m, new decimal[] { 500, 500, 1500, 1000, 1500, 500, 1000, 1500 });
        }
    }

    [SetUp]
    public void SetUp()
    {
        this.classType = typeof(Company);
    }

    [Test]
    public void Company_Class_Is_Public() => AssertThatClassIsPublic(this.classType, false);

    [Test]
    public void Employee_Inherits_Object()
    {
        AssertThatClassInheritsObject(this.classType, typeof(object));
    }

    [TestCase("employees", typeof(IList<Employee>))]
    public void Company_Field_Exists(string fieldName, Type fieldType)
    {
        AssertThatFieldExists(this.classType, fieldName, fieldType);
    }

    [TestCase([typeof(IList<Employee>)])]
    public void Company_Constructor_Exists(params Type[] parameterTypes)
    {
        AssertThatConstructorExists(this.classType, parameterTypes);
    }

    [TestCase("DistributeBonuses", typeof(void), false, false, typeof(decimal))]
    [TestCase("CalculateTotalPayroll", typeof(decimal), false, false)]
    [TestCase("GetHighestPaidEmployeeName", typeof(string), false, false)]
    public void Company_Method_Exists(
        string methodName,
        Type returnType,
        bool isVirtual,
        bool isAbstract,
        params Type[] parameterTypes)
    {
        AssertThatMethodExists(this.classType, methodName, returnType, isVirtual, isAbstract, parameterTypes);
    }

    [Test]
    public void Company_ValidConstructor_InitializesProperties()
    {
        var company = new Company(Employees);
        Assert.Multiple(
            () =>
            {
                Assert.That(
                    company.GetType().GetField(
                            "employees",
                            System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
                        ?.GetValue(company),
                    Is.EqualTo(Employees));
            });
    }

    [Test]
    public void Company_EmployeesIsNull_ThrowsArgumentNullException()
    {
        var exception = Assert.Throws<ArgumentNullException>(() => new Company(null!));
        Assert.That(exception!.ParamName, Is.EqualTo("employees"));
    }

    [TestCaseSource(nameof(ValidBonusData))]
    public void DistributeBonuses_ValidBonus_AssignsBonus(Employee[] employees, decimal bonus, decimal[] bonuses)
    {
        var company = new Company(employees);
        company.DistributeBonuses(bonus);
        Assert.Multiple(
            () =>
            {
                for (int i = 0; i < bonuses.Length; i++)
                {
                    Assert.That(employees[i].CalculateTotalPay(), Is.EqualTo(employees[i].Salary + bonuses[i]));
                }
            });
    }

    [TestCaseSource(nameof(InvalidBonusData))]
    public void DistributeBonuses_InvalidBonus_ThrowsArgumentOutOfRangeException(Employee[] employees, decimal bonus)
    {
        var company = new Company(employees);
        Assert.Throws<ArgumentOutOfRangeException>(() => company.DistributeBonuses(bonus));
    }

    [Test]
    public void CalculateTotalPayroll_ReturnsTotalPayroll()
    {
        var company = new Company(Employees);
        var totalPayroll = Employees.Sum(e => e.CalculateTotalPay());
        Assert.That(company.CalculateTotalPayroll(), Is.EqualTo(totalPayroll));
    }

    [Test]
    public void GetHighestPaidEmployeeName_ThrowsInvalidOperationException_WhenNoEmployees()
    {
        var company = new Company(Array.Empty<Employee>());
        Assert.Throws<InvalidOperationException>(() => company.GetHighestPaidEmployeeName());
    }

    [Test]
    public void GetHighestPaidEmployeeName_ReturnsCorrectEmployeeName()
    {
        var company = new Company(Employees);
        var highestPaidEmployee = Employees.OrderByDescending(e => e.CalculateTotalPay()).First();
        Assert.That(company.GetHighestPaidEmployeeName(), Is.EqualTo(highestPaidEmployee.Name));
    }
}
