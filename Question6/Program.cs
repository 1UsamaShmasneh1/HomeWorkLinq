using StringListCityForQuestions4567;
using System.Text.RegularExpressions;

namespace Question6
{
    public class Program
    {
        public static string? GetContainsX1()
        {
            var expected = (from city in StringListCity.Cities
                           where IsMatchX(city)
                           select city).Take(1);
            return (expected is null)?null:expected.ToString();
        }

        public static string? GetContainsX2()
        {
            var expected = StringListCity.Cities.Where((city) => IsMatchX(city)).ToList();
            return (expected is null) ? null : expected.ToString();
        }

        public static bool IsMatchX(string city)
        {
            Regex regex = new Regex(@"[xX]");
            return regex.IsMatch(city);

        }
        public static void Main()
        {

        }
    }
}