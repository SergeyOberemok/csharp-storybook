using CSharpFunctionalExtensions;

namespace CSharpStorybook.Types.Objects.ValueObject
{
    public class Email : ValueObject<Email>
    {
        public string Value { get; protected set; }

        protected Email()
        {
        }

        protected Email(string value)
        {
            Value = value;
        }

        public static Email Create(string value) => new Email(value);

        protected override bool EqualsCore(Email other)
        {
            return Value == other.Value;
        }

        protected override int GetHashCodeCore()
        {
            return Value.GetHashCode();
        }

        public static implicit operator string(Email email) => email.Value;
        public static explicit operator Email(string email) => new Email(email);
    }
}
