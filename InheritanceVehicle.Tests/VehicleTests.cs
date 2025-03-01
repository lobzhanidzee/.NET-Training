using System.Reflection;
using NUnit.Framework;

namespace InheritanceVehicle.Tests;

[TestFixture]
public class VehicleTests
{
    private const string VehicleClassName = "vehicle";
    private const int ConstructorParamsCount = 2;
    private readonly string[] fields = { "name", "maxSpeed" };
    private Type? vehicleType;

    [SetUp]
    public void Initialize()
    {
        var assembly = typeof(Stub).Assembly;
        this.vehicleType = Array.Find(assembly.GetTypes(), t => t.Name.Equals(VehicleClassName, StringComparison.OrdinalIgnoreCase));
    }

    [Test]
    public void Vehicle_Class_Is_Created()
    {
        Assert.That(this.vehicleType, Is.Not.Null, "'Vehicle' class is not created.");
    }

    [Test]
    public void All_Fields_Are_Defined()
    {
        var vehicleFields = this.vehicleType!.GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.DeclaredOnly);

        var notDefinedFields = (from field in this.fields let vField = Array.Find(vehicleFields, f => f.Name.ToUpperInvariant().Contains(field, StringComparison.InvariantCultureIgnoreCase)) where vField is null select field).ToList();

        if (notDefinedFields.Count == 0)
        {
            notDefinedFields = null;
        }

        Assert.That(notDefinedFields, Is.Null, $"Some field(s) is(are) not define: {notDefinedFields?.Aggregate((previous, next) => $"'{previous}', '{next}'")}");
    }

    [Test]
    public void MaxSpeed_Field_Is_Type_Of_Integer()
    {
        var vehicleFields = this.vehicleType!.GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.DeclaredOnly);
        var field = Array.Find(vehicleFields, f => f.Name.ToUpperInvariant().Contains(this.fields[1], StringComparison.InvariantCultureIgnoreCase));
        Assert.That(field!.FieldType, Is.EqualTo(typeof(int)), $"'{field.Name}' field must be a type of INT.");
    }

    [Test]
    public void Name_Field_Is_Type_Of_String()
    {
        var vehicleFields = this.vehicleType!.GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.DeclaredOnly);
        var field = Array.Find(vehicleFields, f => f.Name.ToUpperInvariant().Contains(this.fields[0], StringComparison.InvariantCultureIgnoreCase));
        Assert.That(field!.FieldType, Is.EqualTo(typeof(string)), $"'{field.Name}' field must be a type of STRING.");
    }

    [Test]
    public void Parametrized_Vehicle_Constructor_Is_Created()
    {
        var paramsConstructor = Array.Find(
            this.vehicleType!.GetConstructors(BindingFlags.Instance | BindingFlags.Public | BindingFlags.DeclaredOnly),
            c =>
            {
                var parameters = c.GetParameters();
                return parameters.Length switch
                {
                    ConstructorParamsCount when (parameters[0].ParameterType == typeof(string) &&
                                                 parameters[1].ParameterType == typeof(int)) ||
                                                (parameters[0].ParameterType == typeof(int) &&
                                                 parameters[1].ParameterType == typeof(string)) => true,
                    ConstructorParamsCount => false,
                    _ => false
                };
            });

        Assert.That(paramsConstructor, Is.Null, "'Vehicle' parametrized constructor is not defined or it does NOT contain appropriate parameters.");
    }

    [Test]
    public void All_Properties_Are_Defined()
    {
        var vehicleProperties = this.vehicleType!.GetProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.DeclaredOnly);

        var notDefinedProperties = (from field in this.fields let property = Array.Find(vehicleProperties, f => f.Name.ToUpperInvariant().Contains(field, StringComparison.InvariantCultureIgnoreCase)) where property is null select field).ToList();

        if (notDefinedProperties.Count == 0)
        {
            notDefinedProperties = null;
        }

        Assert.That(notDefinedProperties, Is.Null, $"Some property(ies) is(are) not define: {notDefinedProperties?.Aggregate((previous, next) => $"'{previous}', '{next}'")}");
    }

    [Test]
    public void Name_Property_Is_Type_Of_String()
    {
        var nonPublicProperties = this.vehicleType!.GetProperties(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.DeclaredOnly);
        var property = Array.Find(nonPublicProperties, p => p.Name.ToUpperInvariant().Contains(this.fields[0], StringComparison.InvariantCultureIgnoreCase));
        Assert.That(property!.PropertyType == typeof(string), $"'{property.Name}' property must be a type of STRING.");
    }

    [Test]
    public void MaxSpeed_Property_Is_Type_Of_Integer()
    {
        var publicProperties = this.vehicleType!.GetProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.DeclaredOnly);
        var property = Array.Find(publicProperties, p => p.Name.ToUpperInvariant().Contains(this.fields[1], StringComparison.InvariantCultureIgnoreCase));
        Assert.That(property!.PropertyType == typeof(int), $"'{property.Name}' property must be a type of INT.");
    }
}
