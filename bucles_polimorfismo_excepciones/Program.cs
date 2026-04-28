var circulo = new Circulo();

circulo.Radio = 20;
var areaCirculo = circulo.Area();
var perimetroCirculo = circulo.Perimetro();

Console.WriteLine($"Área del círculo: {areaCirculo} y el perímetro del círculo: {perimetroCirculo} el radio es: {circulo.Add10()}");

int prev= 0, next = 1, sum;
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(prev);
    sum = prev + next;
    prev = next;
    next = sum;
}




try
{
Console.WriteLine("Ingrese un número a dividir:");
double n= double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el divisor:");
double divisor = double.Parse(Console.ReadLine());
if (divisor == 0)
{
    throw new DivideByZeroException();
}

Console.WriteLine($"El resultado de {n} dividido por {divisor} es: {n / divisor}");
}
catch (DivideByZeroException)
{
    Console.WriteLine("Error: No se puede dividir por cero.");
}
catch (Exception)
{
    Console.WriteLine("Error: Entrada no válida. Por favor, ingrese un número.");
}



/*abstract class Figura
{
    public abstract double Area();

    public abstract double Perimetro();
}*/


interface IextraCalculations    
{
    public double Add10 ();
   
}
interface IFigura
{
    public double Area();

    public double Perimetro();
}

class Circulo : IFigura, IextraCalculations
{
    public double Radio { get; set; }

    public double Area()
    {
        return Math.PI * Math.Pow(Radio, 2);
    }

    public double Perimetro()
    {
        return 2 * Math.PI * Radio;
    }

    public double Add10()
    {
        return Radio + 10;
    }
}