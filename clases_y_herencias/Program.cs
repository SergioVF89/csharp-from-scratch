Console.WriteLine("Hello, World!");
/*clases*/
/*var rect =new rectangulo();
rect.Base = 20;
rect.Altura = 40;    
Console.WriteLine($"El area del rectangulo es: {rect.Area()}");
Console.WriteLine($"El perimetro del rectangulo es: {rect.Perimetro()}");*/
/*end clases*/


var cuadrado1 = new cuadrado();
cuadrado1.Base = 20;
cuadrado1.Altura = 40;
Console.WriteLine($"El area del cuadrado es: {cuadrado1.Area()}");
Console.WriteLine($"El perimetro del cuadrado es: {cuadrado1.Perimetro()}");
Console.WriteLine($"El lado del cuadrado es: {cuadrado1.Lado}");


class rectangulo
{
   public double Base { get; set; }
   public double Altura { get; set; }

    public double Area()=> Base * Altura;
    public double Perimetro()=> 2 * (Base + Altura);
}


class cuadrado: rectangulo
{
    public double Lado { 
        set { Base=value; Altura = value;}

        get { return Base; }    
     
     }
}
//continuar https://www.youtube.com/watch?v=46O0kDrToLU

