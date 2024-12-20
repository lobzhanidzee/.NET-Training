namespace GenericSequenceGenerator
{
    public class DelegateSequenceGenerator<T> : SequenceGenerator<T>
    {
        private readonly Func<T, T, T> generatorFunction;

        public DelegateSequenceGenerator(T first, T second, Func<T, T, T> generatorFunction)
            : base(first, second)
        {
            this.generatorFunction = generatorFunction;
        }

        protected override T GetNext()
        {
            T next = this.generatorFunction(this.Previous, this.Current);
            this.Previous = this.Current;
            this.Current = next;
            this.Count++;
            return next;
        }
    }
}
