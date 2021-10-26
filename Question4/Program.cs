using StringListCityForQuestions4567;
using System.Text.RegularExpressions;

namespace Question4
{
    public class Program
    {
        public static List<string> GetContainsStr1(string str)
        {
            var expected = from city in StringListCity.Cities
                           where IsMatchStr(city, str)
                           select city;
            return expected.ToList();
        }

        public static List<string> GetContainsStr2(string str)
        {
            var expected = StringListCity.Cities.Where((city) => IsMatchStr(city, str));
            return expected.ToList();
        }

        public static bool IsMatchStr(string city, string str)
        {
            Regex regex = new Regex(@str);
            return regex.IsMatch(city);

        }
        public static void Main()
        {
            
        }
    }
}