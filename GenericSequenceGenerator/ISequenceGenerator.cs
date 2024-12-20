namespace GenericSequenceGenerator
{
    public interface ISequenceGenerator<out T>
    {
        T Previous { get; }

        T Current { get; }

        T Next { get; }
    }
}
