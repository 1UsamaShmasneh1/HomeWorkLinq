using ClassCityForQuestions8910;
namespace Question9
{
    public class Program
    {
        public static void Main()
        {
            List<City> list = new List<City>();
            var expected1 = from city in list
                            where city.NumberOfPopulation > 25000
                            select city.Name;
            var expected2 = list.Where(city => city.NumberOfPopulation > 25000).Select(city => city.Name);
        }
    }
}