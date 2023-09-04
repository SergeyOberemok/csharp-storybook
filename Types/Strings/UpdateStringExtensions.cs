namespace CSharpStorybook.Types.Strings
{
    public static class UpdateStringExtensions
    {
        public static string Atob(this string base64Encoded)
        {
            byte[] bytes = Convert.FromBase64String(base64Encoded);
            string base64Decoded = System.Text.Encoding.ASCII.GetString(bytes);

            return base64Decoded;
        }
    }
}
