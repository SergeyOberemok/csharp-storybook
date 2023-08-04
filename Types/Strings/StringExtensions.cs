namespace CSharpStorybook.Types.Strings
{
    public static class StringExtensions
    {
        public static bool IsNumber(this string numberStr)
        {
            return int.TryParse(numberStr, out _);
        }

        public static string Atob(this string base64Encoded)
        {
            byte[] bytes = Convert.FromBase64String(base64Encoded);
            string base64Decoded = System.Text.Encoding.ASCII.GetString(bytes);

            return base64Decoded;
        }
    }
}
