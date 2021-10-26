using StringListCityForQuestions4567;
using System.Text.RegularExpressions;

namespace Question5
{
    public class Program
    {
        public static List<string> GetContainsStr1(string str)
        {
            var expected = from city in StringListCity.Cities
                           where IsNotMatchStr(city, str)
                           select city;
            return expected.ToList();
        }

        public static List<string> GetContainsStr2(string str)
        {
            var expected = StringListCity.Cities.Where((city) => IsNotMatchStr(city, str));
            return expected.ToList();
        }

        public static bool IsNotMatchStr(string city, string str)
        {
            Regex regex = new Regex(@str);
            return !regex.IsMatch(city);

        }
        public static void Main()
        {

        }
    }
}