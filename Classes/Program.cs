namespace Classes
{
    public class Program
    {

        static void Main(string[] args)
        {
            var newCar = new Car();

            newCar.Make = "Ford";
            newCar.Model = "Flex";
            newCar.Year = 2015;

            Console.WriteLine ($"Your new car is a {newCar.Make}. Its model is {newCar.Model}, and it is a {newCar.Year}.");
        }
    }
}
