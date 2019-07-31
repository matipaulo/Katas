using System.Globalization;
using System.Linq;

namespace Katas
{
    public static class CamelCase
    {
        public static string ToCamelCase(this string input)
        {
            var result = string.Empty;
            if (string.IsNullOrEmpty(input))
                return result;

            var words = input.Split(' ').Where(x => x.Length > 0).ToArray();
            foreach (var word in words)
            {
                var characters = word.ToCharArray();
                result += characters[0].ToString().ToUpperInvariant();
                for (var i = 1; i < characters.Length; i++)
                {
                    result += characters[i];
                }
            }

            return result;
        }

        public static string ToImprovedCamelCase(this string input)
        {
            var result = string.Empty;
            if (string.IsNullOrEmpty(input))
                return result;

            var textInfo = new CultureInfo("es-ar").TextInfo;
            result = textInfo.ToTitleCase(input);

            return result.Replace(" ", "");
        }
    }
}
