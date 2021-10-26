namespace Question2
{
    public class Program
    {
        public void Main()
        {
            List<int> list = new List<int>();
            var Odds1 = from num in list
                        where num % 2 == 1
                        orderby num descending
                        select num;
            var Odds2 = list.Where(num => num % 2 == 1).OrderByDescending(num => num);
        }
    }
}