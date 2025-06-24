namespace OfType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            MamaType mama = new MamaType();
            IEnumerable<int> res = mama.GetOfType<object,int>(new object[] { "dasdsa", 4, "dsasdas" });
            Console.WriteLine(res.Count());
            foreach (var s in res)
            {
                Console.WriteLine(s);
            }
        }
    }
}
