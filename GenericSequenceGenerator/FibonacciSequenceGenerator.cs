namespace GenericSequenceGenerator
{
    public class FibonacciSequenceGenerator : SequenceGenerator<int>
    {
        public FibonacciSequenceGenerator(int first, int second)
            : base(first, second)
        {
        }

        protected override int GetNext()
        {
            int next = this.Previous + this.Current;
            this.Previous = this.Current;
            this.Current = next;
            this.Count++;
            return next;
        }
    }
}
