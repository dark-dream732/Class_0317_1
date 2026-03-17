namespace Class_0317_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Test joe, tom, mary;

            joe= new Test();
            mary= new Test();

            joe.Mid = 80;
            joe.Final = 90;

            mary.Mid = 60;
            mary.Final = 66;

            Console.WriteLine("Joe" + joe.GetAvg());

            tom = joe;

            Console.WriteLine("Tom" + joe.GetAvg());

            joe.SetGrade(99, 100);

            Console.WriteLine("Tom" + joe.GetAvg());
        }
    }
}
