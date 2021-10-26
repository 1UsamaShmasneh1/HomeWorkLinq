namespace Question1
{
    public class Program
    {
        public void Main()
        {
            List<int> list = new List<int>();
            var expected1 = from num in list
                            where num < 0
                            select num;
            var expected2 = list.Where(num => num < 0);
        }
    }
}