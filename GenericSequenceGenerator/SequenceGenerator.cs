namespace GenericSequenceGenerator
{
    public abstract class SequenceGenerator<T> : ISequenceGenerator<T>
    {
        public T Previous { get; protected set; }

        public T Current { get; protected set; }

        public T Next => this.GetNext();

        public int Count { get; protected set; }

        protected SequenceGenerator(T first, T second)
        {
            this.Previous = first;
            this.Current = second;
            this.Count = 2;
        }

        protected abstract T GetNext();
    }
}
