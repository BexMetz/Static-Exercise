namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var c = TempConverter.FahrenheitToCelsius(106);
            var f = TempConverter.CelsiusToFahrenheit(13);

            Console.WriteLine($"106 fahrenheit is {c} celsius");
            Console.WriteLine($"13 celsius is {f} fahrenheit");
        }
    }
}
