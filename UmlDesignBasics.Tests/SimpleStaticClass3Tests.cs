using System.Reflection;
using NUnit.Framework;

namespace UmlDesignBasics.Tests
{
    [TestFixture]
    public class SimpleStaticClass3Tests
    {
        private Type classType = null!;

        [SetUp]
        public void SetUp()
        {
            var assembly = typeof(CreatingSimpleClass2).Assembly;
            this.classType = assembly.GetType("UmlDesignBasics.SimpleStaticClass3")!;
        }

        [Test]
        public void IsClass()
        {
            Assert.That(this.classType.IsClass);
        }

        [Test]
        public void IsStaticClass()
        {
            Assert.That(this.classType.IsAbstract);
            Assert.That(this.classType.IsSealed);
        }

        [Test]
        public void IsPublic()
        {
            Assert.That(this.classType.IsPublic);
        }

        [Test]
        public void InheritsObject()
        {
            Assert.That(typeof(object), Is.EqualTo(this.classType.BaseType));
        }

        [Test]
        public void HasRequiredMembers()
        {
            Assert.That(0, Is.EqualTo(this.classType.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.DeclaredOnly).Length));
            Assert.That(4, Is.EqualTo(this.classType.GetMethods(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.DeclaredOnly).Length));
            Assert.That(4, Is.EqualTo(this.classType.GetMethods(BindingFlags.Static | BindingFlags.Public | BindingFlags.DeclaredOnly).Length));

            var flags = BindingFlags.Static | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic;
            Assert.That(0, Is.EqualTo(this.classType.GetFields(flags).Length));
            Assert.That(0, Is.EqualTo(this.classType.GetConstructors(flags).Length));
            Assert.That(0, Is.EqualTo(this.classType.GetEvents(flags).Length));
            Assert.That(0, Is.EqualTo(this.classType.GetProperties(flags).Length));
        }

        [TestCase("GetInteger", typeof(int), false, ExpectedResult = -101)]
        [TestCase("GetLongInteger", typeof(long), true, ExpectedResult = 101L)]
        [TestCase("GetFloat", typeof(float), false, ExpectedResult = 1.01F)]
        [TestCase("GetDouble", typeof(double), true, ExpectedResult = 0.101)]
        [TestCase("GetChar", typeof(char), true, ExpectedResult = 'a')]
        [TestCase("GetBoolean", typeof(bool), false, ExpectedResult = true)]
        [TestCase("GetString", typeof(string), true, ExpectedResult = "abc")]
        [TestCase("GetObject", typeof(object), false, ExpectedResult = null)]
        public object HasRequiredMethod(string methodName, Type methodReturnType, bool isPublic)
        {
            // Arrange
            BindingFlags flags = isPublic
                ? BindingFlags.Static | BindingFlags.Public
                : BindingFlags.Static | BindingFlags.NonPublic;

            // Act
            var methodInfo = this.classType.GetMethod(methodName, flags);

            // Assert
            Assert.That(methodInfo is not null);
            Assert.That(methodInfo!.IsStatic);
            Assert.That(methodReturnType, Is.EqualTo(methodInfo.ReturnType));

            return methodInfo.Invoke(null, Array.Empty<object>())!;
        }
    }
}
