using StringListCityForQuestions4567;

namespace Question6
{
    public class Program
    {        
        public static void Main()
        {
            var expected1 = from city in StringListCity.Cities
                            orderby city
                            select city.Take(3);

            var expectrd2 = StringListCity.Cities.OrderBy(city => city).Take(3);
        }
    }
}