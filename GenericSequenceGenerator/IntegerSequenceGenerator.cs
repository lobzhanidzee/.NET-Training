namespace GenericSequenceGenerator
{
    public class IntegerSequenceGenerator : SequenceGenerator<int>
    {
        public IntegerSequenceGenerator(int first, int second)
            : base(first, second)
        {
        }

        protected override int GetNext()
        {
            int next = (6 * this.Current) - (8 * this.Previous);
            this.Previous = this.Current;
            this.Current = next;
            this.Count++;
            return next;
        }
    }
}
