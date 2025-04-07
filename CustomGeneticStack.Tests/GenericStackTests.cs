using CustomGenericStack;
using NUnit.Framework;

namespace CustomGeneticStack.Tests;

[TestFixture(new[] { 12, 3, 4, int.MaxValue, int.MinValue, 12, 45, -12 }, 8, -12, 45, TypeArgs = new Type[] { typeof(int) })]
[TestFixture(new[] { 0.362, 3.0987, -198.4, -1008245.78, 9012.0001, 0.891 }, 6, 0.891, -198.4, TypeArgs = new Type[] { typeof(double) })]
[TestFixture(new[] { "12", "Zero", "Test", "Hello", "Hello, world!" }, 5, "Hello, world!", "Zero", TypeArgs = new Type[] { typeof(string) })]
[TestFixture(new[] { "12", "Zero", null, "Test", "Hello", null }, 6, null, null, TypeArgs = new Type[] { typeof(string) })]
[TestFixture(new[] { 'a', '\n', '4', '5', '\t' }, 5, '\t', '\n', TypeArgs = new Type[] { typeof(char) })]
[TestFixture(new[] { true, false, true, false }, 4, false, true, TypeArgs = new Type[] { typeof(bool) })]
public class GenericStackTests<T>
{
    private const int SomeValue = 3;
    private readonly T[] setup;
    private readonly T peek;
    private readonly T value;
    private readonly int initCount;
    private GenericStack<T> stack = null!;

    public GenericStackTests(T[] source, int count, T peek, T value)
    {
        this.initCount = count;
        this.setup = new T[source.Length];
        Array.Copy(source, this.setup, this.setup.Length);
        this.peek = peek;
        this.value = value;
    }

    [SetUp]
    public void Init()
    {
        this.stack = new GenericStack<T>(this.setup);
    }

    [Test]
    public void Ctor_BasedOnEnumerableSource()
    {
        Assert.That(this.stack.Count == this.setup.Length);
        Assert.That(this.stack.ToArray(), Is.EqualTo(this.setup.Reverse()));
    }

    [Test]

    public void Iterator_Test()
    {
        int i = this.initCount;
        foreach (var item in this.stack)
        {
            Assert.That(item, Is.EqualTo(this.setup[--i]));
        }
    }

    [Test]
    public void ToArray_Test()
    {
        T[] copy = this.stack.ToArray();
        Assert.Multiple(() =>
        {
            Assert.That(this.setup.Reverse(), Is.EqualTo(copy));
            Assert.That(this.setup, !Is.SameAs(copy));
        });
    }

    [Test]

    public void Push_OneElement()
    {
        int count = this.stack.Count;
        this.stack.Push(this.value);
        Assert.Multiple(() =>
        {
            Assert.That(this.stack.Contains(this.value));
            Assert.That(this.stack.Count == count + 1);
        });
    }

    [Test]
    public void Contains_Test()
    {
        if (this.stack.Count != 0)
        {
            Assert.That(this.stack.Contains(this.value));
        }
        else
        {
            Assert.That(!this.stack.Contains(this.value));
        }
    }

    [Test]
    public void Peek_Test()
    {
        int count = this.stack.Count;
        T actual = this.stack.Peek();
        Assert.Multiple(() =>
        {
            Assert.That(this.stack.Count == count);
            Assert.That(this.peek, Is.EqualTo(actual));
        });
    }

    [Test]
    public void Push_MoreOneElements()
    {
        int count = this.stack.Count;
        for (int i = 1; i <= SomeValue; i++)
        {
            this.stack.Push(this.value);
        }

        Assert.That(this.stack.Count == count + SomeValue);
    }

    [Test]
    public void Pop_MoreOneElements()
    {
        int count = this.stack.Count;

        for (int i = 1; i <= SomeValue; i++)
        {
            _ = this.stack.Pop();
        }

        Assert.That(this.stack.Count == count - SomeValue);
    }

    [Test]
    public void Iterator_PopFromStack_Throw_InvalidOperationException()
    {
        _ = Assert.Throws<InvalidOperationException>(
            () =>
            {
                foreach (var item in this.stack)
                {
                    _ = this.stack.Pop();
                }
            },
            "GenericStack cannot be changed during iteration.");
    }

    [Test]
    public void Iterator_PushIntoStack_Throw_InvalidOperationException()
    {
        Assert.Throws<InvalidOperationException>(
            () =>
            {
                foreach (var item in this.stack)
                {
                    this.stack.Push(this.value);
                }
            },
            "GenericStack cannot be changed during iteration.");
    }

    [Test]
    public void Clear_Test()
    {
        this.stack.Clear();
        Assert.That(this.stack.Count == 0);
        Assert.That(this.stack.ToArray(), Is.EqualTo(Array.Empty<T>()));
    }

    [Test]
    public void Pop_StackIsEmpty_ThrowInvalidOperationException()
    {
        this.stack = new GenericStack<T>(0);
        Assert.Throws<InvalidOperationException>(() => this.stack.Pop(), "Invalid operation pop, stack is empty.");
    }
}
