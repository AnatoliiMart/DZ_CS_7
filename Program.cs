namespace DZ_CS_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IICalc i = new ArrayInt(15);
            i.Show();
            C();
            i.ShowEven();
            C();
            C();
            i.ShowOdd();
            C();
            C();
            Console.WriteLine(i.Greater(50));
            C();
            Console.WriteLine(i.Less(30));
            C();
            Console.WriteLine(i.CountDistinct());
            C();
            Console.WriteLine(i.EqualToValue(43));
        }
        static void C() => Console.WriteLine();

    }
}