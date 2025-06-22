namespace OfType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            MamaType mama = new MamaType();
            IEnumerable<string> res = mama.GetOfType<string>(new object[] { "dasdsa", 4, "dsasdas" });
            Console.WriteLine(res.Count());
            foreach (string s in res)
            {
                Console.WriteLine(s);
            }
        }
    }
}
