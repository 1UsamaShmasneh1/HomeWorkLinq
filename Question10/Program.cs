using ClassCityForQuestions8910;
namespace Question10
{
    public class Program
    {
        public static void Main()
        {
            List<City> list = new List<City>();
            var expected1 = from city in list
                            select new { city.Name, IsCityOrLocality = (city.NumberOfPopulation > 25000) ? "City" : "Locality" };
            var expected2 = list.Select(city => new { city.Name, IsCityOrLocality = (city.NumberOfPopulation > 25000) ? "City" : "Locality" });
        }
    }
}