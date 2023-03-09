namespace CSharpStorybook.Types.Strings
{
    public static class StringExtensions
    {
        public static bool IsNumber(this string numberStr)
        {
            return int.TryParse(numberStr, out _);
        }
    }
}
