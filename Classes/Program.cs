//-JESUS
namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            var mycar = new Car();
            mycar.Make = "Ford";
            Console.WriteLine(mycar.Make);
            mycar.Year = 2017;
            Console.WriteLine(mycar.Year);
            mycar.Model = "Accord";
            Console.WriteLine(mycar.Model);
        }
    }
}
