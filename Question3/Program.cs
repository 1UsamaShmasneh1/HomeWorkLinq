namespace Question3
{
    public class Program
    {
        public void Main()
        {
            List<int> list = new List<int>();
            var expected1 = from num in list
                            where num > 0 && num % 3 != 0
                            select num * 3;
            var expected2 = list.Where(num => num > 0 && num % 3 != 0).Select(num => num * 3);
        }
    }
}