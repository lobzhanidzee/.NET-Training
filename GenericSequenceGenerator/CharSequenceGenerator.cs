namespace GenericSequenceGenerator
{
    public class CharSequenceGenerator : SequenceGenerator<char>
    {
        public CharSequenceGenerator(char first, char second)
            : base(first, second)
        {
        }

        protected override char GetNext()
        {
            char next = (char)(((this.Current - 'A' + (this.Previous - 'A')) % 26) + 'A');
            this.Previous = this.Current;
            this.Current = next;
            this.Count++;
            return next;
        }
    }
}
