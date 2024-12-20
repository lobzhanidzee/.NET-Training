namespace GenericSequenceGenerator
{
    public class DoubleSequenceGenerator : SequenceGenerator<double>
    {
        public DoubleSequenceGenerator(double first, double second)
            : base(first, second)
        {
        }

        protected override double GetNext()
        {
            double next = this.Current + (this.Previous / this.Current);
            this.Previous = this.Current;
            this.Current = next;
            this.Count++;
            return next;
        }
    }
}
