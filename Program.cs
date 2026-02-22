public class Program
{
    public Program()
    {

    }
    public static async Task Main(string[] args)
    {
        if (args.Count() <= 0)
        {
            Console.WriteLine("Por favor use algum paramentro: \nsum -Adição , \nsub-> Subtração, \nmul->multiplicação ou \ndiv -> Divisão");
        }
        else
        {


            string comand = args[0];
            string[] comandLine = args.Where((value, index) => index != 0).ToArray();

            List<double> Numbers = [];

            for (int i = 0; i < comandLine.Count(); i++)
            {

                double number = double.Parse(comandLine[i]);
                Numbers.Add(number);
                Console.WriteLine($"{comand.ToUpper()}: {comandLine[i]}");
            }
            switch (comand.ToLower())
            {
                case "sum":
                    Console.WriteLine($"Resultado: {Sum(Numbers)}");
                    break;
                case "sub":
                    Console.WriteLine($"Resultado: {Sub(Numbers)}");
                    break;
                case "mult":

                    Console.WriteLine($"Resultado: {Mult(Numbers)}");
                    break;
                case "div":
                    if (Numbers.Count() > 2)
                        Console.WriteLine("Esta operação aceita apenas 2 numero como parametro");
                    else
                        Console.WriteLine($"Resultado: {Div(Numbers)}");
                    break;
                default:
                    Console.WriteLine("Comando Invalido");
                    break;
            }
        }

    }
    public static double Sum(List<double> numbers)
    {
        double result = 0;
        for (int i = 0; i < numbers.Count(); i++)
        {
            result = result + numbers[i];
        }
        return result;
    }

    public static double Sub(List<double> numbers)
    {
        double result = 0;
        for (int i = 0; i < numbers.Count(); i++)
        {

            if (result != 0)
            {
                result = result - numbers[i];
            }
            else
            {
                result = numbers[i];
            }
        }
        return result;
    }
    public static double Mult(List<double> numbers)
    {
        double result = 0;
        for (int i = 0; i < numbers.Count(); i++)
        {

            if (result != 0)
            {
                result = result * numbers[i];
            }
            else
            {
                result = numbers[i];
            }
        }
        return result;
    }
    public static double Div(List<double> numbers)
    {

        double result = 0;
        for (int i = 0; i < numbers.Count(); i++)
        {

            if (result != 0)
            {
                result = result / numbers[i];
            }
            else
            {
                result = numbers[i];
            }
        }
        return result;
    }
}