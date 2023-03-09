namespace CSharpStorybook.Models
{
    public class Person
    {
        public string Name { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public Gender Gender { get; set; } // 0 is Male; 1 is Female

        public override string ToString() => $"Person is {Name} {Username} with email: {Email}";
    }

    public enum Gender : int
    {
        Male = 0,
        Female = 1
    }
}
