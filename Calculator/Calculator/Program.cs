using Calculator;
Calculate Calculator = new();

Console.WriteLine("\t\t\t__________");
Console.WriteLine("\t\t\tCalculator");
Console.WriteLine("\t\t\t__________");

Console.Write("Please Use First Number: ");
Calculator.FirstNumMethod(Convert.ToDouble(Console.ReadLine()));
Console.Write("Please Use Option: ");
Calculator.GetOption();
Console.Write("Please Use Second Number: ");
Calculator.SecondNumMethod(Convert.ToDouble(Console.ReadLine()));
Calculator.Calculation();
