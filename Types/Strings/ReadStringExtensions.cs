namespace CSharpStorybook.Types.Strings
{
    public static class ReadStringExtensions
    {
        public static bool IsNumber(this string numberStr)
        {
            return int.TryParse(numberStr, out _);
        }
    }
}
