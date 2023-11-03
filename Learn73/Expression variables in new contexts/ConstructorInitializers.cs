namespace Learn73.Expression_variables_in_new_contexts
{
    public class ConstructorInitializers
    {
        private readonly bool _wrapsPositiveNumber;
        public readonly int Number;
        private ConstructorInitializers(bool wrapsPositiveNumber)
        {
            _wrapsPositiveNumber = wrapsPositiveNumber;
        }
        public ConstructorInitializers(string str)
            : this(int.TryParse(str, out var input) && input > 0)
        {
            // "input" is available in the scope of the constructor
            Number = input;
        }
    }
}